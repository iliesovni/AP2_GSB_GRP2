-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
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
CREATE PROCEDURE MiseAJourNombreMedicaments
@depot_legal VARCHAR(100), @nom_commercial VARCHAR(100), @composition VARCHAR(100), @effets VARCHAR(100), @contre_indications VARCHAR(100), @med_amm VARCHAR(100), @fam_code_medicament VARCHAR(100)
AS 
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    -- Insert statements for procedure here
    UPDATE FAMILLE
    SET FAM_NB_MED_AMM = (
        SELECT COUNT(*)
        FROM MEDICAMENT
        WHERE MEDICAMENT.FAM_CODE_MEDICAMENT = FAMILLE.FAM_CODE);
END
GO
