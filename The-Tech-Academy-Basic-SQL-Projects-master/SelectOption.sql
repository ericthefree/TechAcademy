/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [species_id]
      ,[species_name]
      ,[species_animalia]
      ,[species_class]
      ,[species_order]
      ,[species_habitat]
      ,[species_nutrition]
      ,[species_care]
  FROM [db_zoo].[dbo].[tbl_species]