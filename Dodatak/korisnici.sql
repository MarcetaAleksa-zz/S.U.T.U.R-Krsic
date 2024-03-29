USE [S.U.T.U.R_Krsic]
GO
/****** Object:  Table [dbo].[korisnici]    Script Date: 12/4/2019 4:11:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[korisnici](
	[korisnicki_id] [varchar](50) NOT NULL,
	[ime_korisnika] [varchar](50) NULL,
	[prezime_korisnika] [varchar](50) NULL,
	[lozinka] [varchar](160) NOT NULL,
	[adresa_stanovanja] [varchar](60) NULL,
	[broj_telefona] [varchar](12) NULL,
	[email] [varchar](50) NULL,
	[datum_rodjenja] [date] NULL,
	[pol] [varchar](6) NULL,
	[radna_pozicija] [smallint] NULL,
 CONSTRAINT [PK_korisnici] PRIMARY KEY CLUSTERED 
(
	[korisnicki_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[korisnici] ([korisnicki_id], [ime_korisnika], [prezime_korisnika], [lozinka], [adresa_stanovanja], [broj_telefona], [email], [datum_rodjenja], [pol], [radna_pozicija]) VALUES (N'AmarBa', N'Elvir', N'Lovic', N'€104A411CA4B531797AF876ADDEB564226A520DC5F346D1BB2B6A82580EF8ED786864CF5B4FC70198E54622AE6D7284DC8FC02CAB089CC0D131B5CE150E7088C8', N'Krajiskih Brigada 11e', N'38765420690', N'elvir.lovic@suturk.ba', CAST(N'1998-03-11' AS Date), N'Muski', 6)
INSERT [dbo].[korisnici] ([korisnicki_id], [ime_korisnika], [prezime_korisnika], [lozinka], [adresa_stanovanja], [broj_telefona], [email], [datum_rodjenja], [pol], [radna_pozicija]) VALUES (N'HarunH', N'Harun', N'Hotic', N'€CEC5800574EDC9BF5CDBA63BB5B88C8394973131BF9EC2CD8977F1E2353D91994CF98A4A0B87A09C4D49AF78D39910A903FD6AE11403F4ED22592B89B874CB2C', N'Carice Milice 9b', N'38766404000', N'harun.hotic@suturk.ba', CAST(N'1998-12-25' AS Date), N'Muski', 4)
INSERT [dbo].[korisnici] ([korisnicki_id], [ime_korisnika], [prezime_korisnika], [lozinka], [adresa_stanovanja], [broj_telefona], [email], [datum_rodjenja], [pol], [radna_pozicija]) VALUES (N'IgorG', N'Igor', N'Gojkovic', N'€D37D104D437B355690703295E9E297E4EDBFC9AFB778F3456CFEA181C326A792B69DC99307C94F26F6062CDCCCB5CA81A2090E4121AC33FBB1F96F34C1DDD9B4', N'Zore Kovacevic 9a', N'38765422122', N'igor.gojkovic@sutur.ba', CAST(N'1998-05-22' AS Date), N'Muski', 3)
INSERT [dbo].[korisnici] ([korisnicki_id], [ime_korisnika], [prezime_korisnika], [lozinka], [adresa_stanovanja], [broj_telefona], [email], [datum_rodjenja], [pol], [radna_pozicija]) VALUES (N'MarLeksa', N'Aleksa', N'Marceta', N'€14CF66282C7049EA3752D204EDC145746BC488A4B639AD88AD0506A87E38C7136B4C224E4A8AB88E775D331DC2E0FD93E872AD021D82F3B39B2F4DB6CBD204AB', N'Zore Kovacevic 9a', N'38766311227', N'aleksa.marceta@suturk.ba', CAST(N'1998-01-23' AS Date), N'Muski', 1)
INSERT [dbo].[korisnici] ([korisnicki_id], [ime_korisnika], [prezime_korisnika], [lozinka], [adresa_stanovanja], [broj_telefona], [email], [datum_rodjenja], [pol], [radna_pozicija]) VALUES (N'NevenK', N'Neven', N'Krsic', N'€E6457001DC93F8CA14AE56A690D510A1CA3DE3B5A27AE01F73C6CB90AF94E5BADD2571BB4BF312B6468CE02CF816634FA7C9BE1197ACAEFD6D128BEF2CE24E2E', N'Slavka Rodica 2a', N'38765493201', N'neven.krsic@suturk.ba', CAST(N'1996-11-03' AS Date), N'Muski', 2)
INSERT [dbo].[korisnici] ([korisnicki_id], [ime_korisnika], [prezime_korisnika], [lozinka], [adresa_stanovanja], [broj_telefona], [email], [datum_rodjenja], [pol], [radna_pozicija]) VALUES (N'NikolaS', N'Nikola', N'Stankovic', N'€82AE8767186DF1011DAD8AA7F8B009CAF1FF0E0F7381B37165768D8F47174092654747E58FACF07A4D4813127BD2C19C7016E6BDC069DFE1F717179C9C46BD56', N'Slavka Rodica 2a', N'38766423123', N'nikola.stankovic@suturk.ba', CAST(N'1998-03-13' AS Date), N'Muski', 4)
INSERT [dbo].[korisnici] ([korisnicki_id], [ime_korisnika], [prezime_korisnika], [lozinka], [adresa_stanovanja], [broj_telefona], [email], [datum_rodjenja], [pol], [radna_pozicija]) VALUES (N'Panzoa', N'Aleksandar', N'Panzalovic', N'€824BD0CF86B6ED79F09B067FA50BFF3969225C3C726DB62277F47B90002CD1976D768E34064FE22A3991041073883A6F7432C9CCD42F92C2FBE217A0563A638E', N'Slavka Rodica 2a', N'38766845565', N'aleksandar.panzalovic@suturk.ba', CAST(N'1998-05-21' AS Date), N'Muski', 1)
INSERT [dbo].[korisnici] ([korisnicki_id], [ime_korisnika], [prezime_korisnika], [lozinka], [adresa_stanovanja], [broj_telefona], [email], [datum_rodjenja], [pol], [radna_pozicija]) VALUES (N'PetarK', N'Petar', N'Krsic', N'€8D3B387A13D83CAE1B21D96A8AA911605C25F59E1A8542319E7429ECD2C3E9D372A41FBFBF51D903F506950FA3094DBE0CF63358BD1CE7C5B3B182097033C636', N'Osinjska EE', N'387632399099', N'petar.krsic@suturk.ba', CAST(N'2002-04-29' AS Date), N'Muski', 2)
INSERT [dbo].[korisnici] ([korisnicki_id], [ime_korisnika], [prezime_korisnika], [lozinka], [adresa_stanovanja], [broj_telefona], [email], [datum_rodjenja], [pol], [radna_pozicija]) VALUES (N'SasaB', N'Sasa', N'Bundalo', N'€824BD0CF86B6ED79F09B067FA50BFF3969225C3C726DB62277F47B90002CD1976D768E34064FE22A3991041073883A6F7432C9CCD42F92C2FBE217A0563A638E', N'Slavka Rodica 5o', N'38766539219', N'sasa.bundalo@suturk.ba', CAST(N'1998-11-15' AS Date), N'Muski', 5)
INSERT [dbo].[korisnici] ([korisnicki_id], [ime_korisnika], [prezime_korisnika], [lozinka], [adresa_stanovanja], [broj_telefona], [email], [datum_rodjenja], [pol], [radna_pozicija]) VALUES (N'SinisaGl', N'Sinisa', N'Gligoric', N'€DD8FA93B595FF61B63D78B1B7A6BFD1A95200F4E52F5CEE5E3E35CA2B0317E4874122171AABFD87E052BD0954BBDDDBBF435C517B9F143A29670EE3E2208B030', N'Junaci iz Borika 11a', N'38766301065', N'sinisa.gligoric@suturk.ba', CAST(N'1998-07-03' AS Date), N'Muski', 4)
ALTER TABLE [dbo].[korisnici]  WITH CHECK ADD  CONSTRAINT [FK_korisnici_korisnici] FOREIGN KEY([radna_pozicija])
REFERENCES [dbo].[pozicija] ([pozicija_id])
GO
ALTER TABLE [dbo].[korisnici] CHECK CONSTRAINT [FK_korisnici_korisnici]
GO
