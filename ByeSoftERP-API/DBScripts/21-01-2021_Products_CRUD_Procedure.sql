Create Procedure sp_GetProductByID
@ProdID Char(36)
As   
Begin  
	Select * From Products Where ProdID = @ProdID;  
End

Go

Create Procedure sp_GetProducts
@ProdID Char(36)
As   
Begin  
	Select * From Products Order By ProdCreatedDate Desc;  
End

Create Procedure sp_SaveProduct
@ProdID Char(36) = NULL,
@ProdNum nVarChar(16) = Null,
@ProdName nVarChar(256) = Null,
@ProdDesc nVarChar(1024) = Null,
@ProdIsActive Int = Null,
@UOMID Char(36) = Null,
@ProdTypeID Char(36) = Null,
@ProdHSNCode nVarChar(16) = Null,
@Comments nVarChar(2048) = Null,
@Mode nVarChar(6) Not Null,
@Validation_msg nVarChar(1024) OutPut,
@IsSuccess Int OutPut
As
Begin 
	Begin Try
		If (@Mode = 'NEW')
		Begin
			If Exists (Select Top 1 ProdNum From Products Where ProdNum = @ProdNum)
			Begin
				Set @Validation_msg = 'Prod No. already exists'
				Set @IsSuccess  = 2
			End
			Else If Exists (Select Top 1 ProdName From Products Where ProdName = @ProdName)
			Begin
				Set @Validation_msg = 'ProdName already exists'
				Set @IsSuccess  = 2
			End
			Else
			Begin
				Insert Into Products Values(@ProdID, @ProdNum, @ProdName, @ProdDesc, @ProdIsActive, @UOMID, @ProdTypeID, @ProdHSNCode, @Comments, GETDATE(), Null)
				Set @IsSuccess  = 1
			End
		End
		Else If (@Mode = 'EDIT')
		Begin
			If Exists (Select Top 1 ProdNum From Products Where ProdNum = @ProdNum And ProdID != @ProdID)
			Begin
				Set @Validation_msg = 'Prod No. already exists'
				Set @IsSuccess  = 2
			End
			Else If Exists (Select Top 1 ProdName From Products Where ProdName = @ProdName And ProdID != @ProdID)
			Begin
				Set @Validation_msg = 'ProdName already exists'
				Set @IsSuccess  = 2
			End
			Else
			Begin
				Update Products Set ProdNum = @ProdNum, ProdName = @ProdName, ProdDesc = @ProdDesc, ProdIsActive = @ProdIsActive, UOMID = @UOMID, ProdTypeID = @ProdTypeID,
				ProdHSNCode = @ProdHSNCode, Comments = @Comments, ProdUpdatedDate = GETDATE()
				Set @IsSuccess  = 1
			End
		End
		Else If(@Mode = 'DELETE')
		Begin
			Delete From Products Where ProdID = @ProdID
			Set @IsSuccess = 1
		End
	End Try
	Begin Catch
		Set @IsSuccess = 0
	End Catch
End

