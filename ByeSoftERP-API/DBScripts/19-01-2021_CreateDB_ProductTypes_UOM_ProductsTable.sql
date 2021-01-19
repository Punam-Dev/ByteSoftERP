Create DataBase ByteSoftERP;

Go

Use ByteSoftERP;

Go

Create Table ProductTypes
(
	ProdTypeID Char(36) Primary Key Not Null,
	ProdTypeName nVarChar(32) Not Null,
	ProdTypeDesc nVarChar(128) Not Null,
	ProdTypeIndex Int Not Null,

	Constraint UQ_ProductTypes_ProdTypeName Unique(ProdTypeName),
	Constraint UQ_ProductTypes_ProdTypeIndex Unique(ProdTypeIndex)
)

Go

Create Table UOMS
(
	UOMID Char(36) Primary Key Not NULL,
	UOMName nVarChar(32) Not Null,
	UOMCode nVarChar(8) Not Null,
	UOMDesc nVarChar(128) Not Null,
	UOMIndex int Not Null,

	Constraint UQ_UOMS_UOMCode Unique(UOMCode),
	Constraint UQ_UOMS_ProdTypeName Unique(UOMName),
	Constraint UQ_UOMS_ProdTypeIndex Unique(UOMIndex)
)
Go
Create Table Products
(
	ProdID Char(36) Primary Key Not NULL,
	ProdNum nVarChar(16) Not Null,
	ProdName nVarChar(256) Not Null,
	ProdDesc nVarChar(1024) Not Null,
	ProdIsActive Int Not Null,
	UOMID Char(36) Not Null,
	ProdTypeID Char(36) Not Null,
	ProdHSNCode nVarChar(16),
	Comments nVarChar(2048),
	ProdCreatedDate DateTime Not Null,
	ProdUpdatedDate DateTime,

	Constraint FK_Products_ProductTypes_ProdTypeID Foreign Key(ProdTypeID) References ProductTypes(ProdTypeID),
	Constraint FK_Products_UOMs_UOMID Foreign Key(UOMID) References UOMs(UOMID),
	Constraint UQ_Products_ProdNum Unique(ProdNum),
	Constraint UQ_Products_ProdName Unique(ProdName)
)