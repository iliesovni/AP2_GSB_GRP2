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
CREATE PROCEDURE prc_getEtapes
AS
BEGIN

    SET NOCOUNT ON;

    SELECT ETP_NUM, ETP_LIBELLE, ETP_NORME, ETP_DATE_NORME
    FROM ETAPE
    INNER JOIN ETAPE_NORME ON ETP_NUM = ETP_NUM_NORME
END
GO
