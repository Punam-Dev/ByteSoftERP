Alter Procedure sp_GetUOMs  
As   
Begin  
	Select * From UOMS Order By UOMIndex;  
End  

GO

Alter Procedure sp_GetProductTypes  
As   
Begin  
	Select * From ProductTypes Order By ProdTypeIndex;  
End  
  
  