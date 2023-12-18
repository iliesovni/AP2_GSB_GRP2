-- ================================================
-- Template generated from Template Explorer using:
-- Create Trigger (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- See additional Create Trigger templates for more
-- examples of different Trigger statements.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER VerifExisteFamille
   ON  MEDICAMENT
   INSTEAD OF INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here
	DECLARE @depotlegal VARCHAR(10)
	DECLARE @nomcommercial VARCHAR(25)
	DECLARE @composition VARCHAR(255)
	DECLARE @effets VARCHAR(255)
	DECLARE @contreindic VARCHAR(255)
	DECLARE @amm VARCHAR(10)
	DECLARE @famille VARCHAR(3)

	SELECT @famille = FAM_CODE_MEDICAMENT FROM inserted
		IF NOT EXISTS (SELECT 1 FROM FAMILLE WHERE FAM_CODE = @famille)
	BEGIN
		RAISERROR('La famille spécifiée n''existe pas dans la table FAMILLE.', 16, 1)
		RETURN;
	END

	INSERT INTO MEDICAMENT(MED_DEPOTLEGAL, MED_NOMCOMMERCIAL, MED_COMPOSITION, MED_EFFETS, MED_CONTREINDIC, MED_AMM, FAM_CODE_MEDICAMENT) VALUES(@depotlegal, @nomcommercial, @composition, @effets, @contreindic, @amm, @famille)
END
GO
