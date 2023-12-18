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
CREATE PROCEDURE VerifierMedicamentDansEtapeNormee
	@MED_DEPOTLEGAL VARCHAR(255),
    @Resultat INT OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SET @Resultat = 0;

	IF EXISTS (SELECT 1 FROM DERNIERE_VALIDATION WHERE MED_DEPOTLEGAL_DV = @MED_DEPOTLEGAL)
        BEGIN
            -- Mettre à jour le résultat à 1 (true) si le médicament est trouvé dans DERNIERE_VALIDATION
            SET @Resultat = 1;
        END
END
GO
