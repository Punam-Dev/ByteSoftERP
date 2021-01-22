Create Table ErrorLog
(
	ErrorLogID Char(36) Primary Key Not Null,
	PageURL nVarChar(1024) Not Null,
	HTTPVerb nVarChar(8) Not Null,
	ErrorMessage nVarChar(Max),
	StrackTrace nVarChar(Max),
	InnerException nVarChar(Max),
	CreatedDate DateTime
)

Go

Create Procedure InsertErrorLog
@ErrorLogID Char(36),
@PageURL nVarChar(1024),
@HTTPVerb nVarChar(8),
@ErrorMessage nVarChar(Max),
@StrackTrace nVarChar(Max),
@InnerException nVarChar(Max)
As
Begin
	Insert Into ErrorLog Values(@ErrorLogID, @PageURL, @HTTPVerb, @ErrorMessage, @StrackTrace, @InnerException, GETDATE())
End