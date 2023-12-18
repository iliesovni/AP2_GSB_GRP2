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
CREATE PROCEDURE prc_ajout_medicament
@depot_legal VARCHAR(100), @nom_commercial VARCHAR(100), @composition VARCHAR(100), @effets VARCHAR(100), @contre_indications VARCHAR(100), @med_amm VARCHAR(100), @fam_code_medicament VARCHAR(100)
AS 
BEGIN

    INSERT INTO MEDICAMENT(MED_DEPOTLEGAL, MED_NOMCOMMERCIAL, MED_COMPOSITION, MED_EFFETS, MED_CONTREINDIC, MED_AMM, FAM_CODE_MEDICAMENT)
    VALUES (@depot_legal, @nom_commercial, @composition, @effets, @contre_indications, @med_amm, @fam_code_medicament)
END
GO
