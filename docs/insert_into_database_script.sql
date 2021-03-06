USE [Clinic]
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([IsActive], [Username], [Password], [RegistrationDate], [Role], [Id]) VALUES (1, N'admin', N'5B722B307FCE6C944905D132691D5E4A2214B7FE92B738920EB3FCE3A90420A19511C3010A0E7712B054DAEF5B57BAD59ECBD93B3280F210578F547F4AED4D25', CAST(N'2017-06-22T12:30:48.100' AS DateTime), N'ADM', 1)
INSERT [dbo].[User] ([IsActive], [Username], [Password], [RegistrationDate], [Role], [Id]) VALUES (0, N'doc1', N'5B722B307FCE6C944905D132691D5E4A2214B7FE92B738920EB3FCE3A90420A19511C3010A0E7712B054DAEF5B57BAD59ECBD93B3280F210578F547F4AED4D25', CAST(N'2017-06-27T15:25:40.460' AS DateTime), N'DOC', 9)
INSERT [dbo].[User] ([IsActive], [Username], [Password], [RegistrationDate], [Role], [Id]) VALUES (0, N'doc2', N'5B722B307FCE6C944905D132691D5E4A2214B7FE92B738920EB3FCE3A90420A19511C3010A0E7712B054DAEF5B57BAD59ECBD93B3280F210578F547F4AED4D25', CAST(N'2017-06-27T15:25:50.677' AS DateTime), N'DOC', 10)
INSERT [dbo].[User] ([IsActive], [Username], [Password], [RegistrationDate], [Role], [Id]) VALUES (0, N'doc3', N'5B722B307FCE6C944905D132691D5E4A2214B7FE92B738920EB3FCE3A90420A19511C3010A0E7712B054DAEF5B57BAD59ECBD93B3280F210578F547F4AED4D25', CAST(N'2017-06-27T15:26:13.910' AS DateTime), N'DOC', 11)
INSERT [dbo].[User] ([IsActive], [Username], [Password], [RegistrationDate], [Role], [Id]) VALUES (0, N'reg1', N'5B722B307FCE6C944905D132691D5E4A2214B7FE92B738920EB3FCE3A90420A19511C3010A0E7712B054DAEF5B57BAD59ECBD93B3280F210578F547F4AED4D25', CAST(N'2017-06-27T15:26:38.767' AS DateTime), N'REG', 12)
INSERT [dbo].[User] ([IsActive], [Username], [Password], [RegistrationDate], [Role], [Id]) VALUES (0, N'reg2', N'5B722B307FCE6C944905D132691D5E4A2214B7FE92B738920EB3FCE3A90420A19511C3010A0E7712B054DAEF5B57BAD59ECBD93B3280F210578F547F4AED4D25', CAST(N'2017-06-27T15:27:06.557' AS DateTime), N'REG', 13)
INSERT [dbo].[User] ([IsActive], [Username], [Password], [RegistrationDate], [Role], [Id]) VALUES (0, N'reg3', N'5B722B307FCE6C944905D132691D5E4A2214B7FE92B738920EB3FCE3A90420A19511C3010A0E7712B054DAEF5B57BAD59ECBD93B3280F210578F547F4AED4D25', CAST(N'2017-06-27T15:27:16.010' AS DateTime), N'REG', 14)
INSERT [dbo].[User] ([IsActive], [Username], [Password], [RegistrationDate], [Role], [Id]) VALUES (0, N'lab1', N'5B722B307FCE6C944905D132691D5E4A2214B7FE92B738920EB3FCE3A90420A19511C3010A0E7712B054DAEF5B57BAD59ECBD93B3280F210578F547F4AED4D25', CAST(N'2017-06-27T15:27:56.353' AS DateTime), N'LABASS', 15)
INSERT [dbo].[User] ([IsActive], [Username], [Password], [RegistrationDate], [Role], [Id]) VALUES (0, N'lab2', N'5B722B307FCE6C944905D132691D5E4A2214B7FE92B738920EB3FCE3A90420A19511C3010A0E7712B054DAEF5B57BAD59ECBD93B3280F210578F547F4AED4D25', CAST(N'2017-06-27T15:28:43.870' AS DateTime), N'LABASS', 16)
INSERT [dbo].[User] ([IsActive], [Username], [Password], [RegistrationDate], [Role], [Id]) VALUES (0, N'labman', N'5B722B307FCE6C944905D132691D5E4A2214B7FE92B738920EB3FCE3A90420A19511C3010A0E7712B054DAEF5B57BAD59ECBD93B3280F210578F547F4AED4D25', CAST(N'2017-06-27T15:29:17.803' AS DateTime), N'LABMAN', 17)
SET IDENTITY_INSERT [dbo].[User] OFF
INSERT [dbo].[Doctor] ([Id], [LicenseNumber], [Name], [Surname]) VALUES (9, N'          ', N'Gregory', N'House')
INSERT [dbo].[Doctor] ([Id], [LicenseNumber], [Name], [Surname]) VALUES (10, N'          ', N'John', N'Smith')
INSERT [dbo].[Doctor] ([Id], [LicenseNumber], [Name], [Surname]) VALUES (11, N'          ', N'Albert', N'Partridge')
SET IDENTITY_INSERT [dbo].[Patient] ON 

INSERT [dbo].[Patient] ([Id], [Name], [Surname], [PESEL]) VALUES (6, N'Walter', N'White', N'85031575056')
INSERT [dbo].[Patient] ([Id], [Name], [Surname], [PESEL]) VALUES (7, N'James', N'Brown', N'94100176854')
INSERT [dbo].[Patient] ([Id], [Name], [Surname], [PESEL]) VALUES (8, N'Jason', N'Bourne', N'80080313745')
INSERT [dbo].[Patient] ([Id], [Name], [Surname], [PESEL]) VALUES (9, N'Jack', N'Reacher', N'84103198236')
INSERT [dbo].[Patient] ([Id], [Name], [Surname], [PESEL]) VALUES (10, N'Harrison', N'Ford', N'42071356691')
INSERT [dbo].[Patient] ([Id], [Name], [Surname], [PESEL]) VALUES (11, N'Donald', N'Trump', N'46061498891')
INSERT [dbo].[Patient] ([Id], [Name], [Surname], [PESEL]) VALUES (12, N'Gregory', N'Smith', N'78060612854')
INSERT [dbo].[Patient] ([Id], [Name], [Surname], [PESEL]) VALUES (13, N'Lucy', N'Fur', N'06060616662')
SET IDENTITY_INSERT [dbo].[Patient] OFF
INSERT [dbo].[Registrator] ([Id], [Name], [Surname]) VALUES (12, N'Reggie', N'Strator')
INSERT [dbo].[Registrator] ([Id], [Name], [Surname]) VALUES (13, N'Denise', N'Malcolm')
INSERT [dbo].[Registrator] ([Id], [Name], [Surname]) VALUES (14, N'Judy', N'Smith')
SET IDENTITY_INSERT [dbo].[Visit] ON 

INSERT [dbo].[Visit] ([Id], [Description], [Diagnosis], [Status], [RegistrationDate], [ResolutionDate], [PlannedDate], [IdRegistrator], [IdPatient], [IdDoctor]) VALUES (12, N'Bóle klatki piersiowej, gorączka.', N'Podejrzenie raka mózgu.', N'FIN', CAST(N'2017-06-27T15:47:58.407' AS DateTime), NULL, CAST(N'2017-06-27T13:15:00.000' AS DateTime), 12, 6, 9)
INSERT [dbo].[Visit] ([Id], [Description], [Diagnosis], [Status], [RegistrationDate], [ResolutionDate], [PlannedDate], [IdRegistrator], [IdPatient], [IdDoctor]) VALUES (13, N'', NULL, N'REM', CAST(N'2017-06-27T15:49:02.083' AS DateTime), NULL, CAST(N'2017-06-27T14:00:00.000' AS DateTime), 12, 6, 9)
INSERT [dbo].[Visit] ([Id], [Description], [Diagnosis], [Status], [RegistrationDate], [ResolutionDate], [PlannedDate], [IdRegistrator], [IdPatient], [IdDoctor]) VALUES (14, N'Empty', N'Empty', N'CAN', CAST(N'2017-06-27T15:49:29.337' AS DateTime), CAST(N'2017-06-27T16:21:15.950' AS DateTime), CAST(N'2017-06-28T08:00:00.000' AS DateTime), 12, 6, 10)
INSERT [dbo].[Visit] ([Id], [Description], [Diagnosis], [Status], [RegistrationDate], [ResolutionDate], [PlannedDate], [IdRegistrator], [IdPatient], [IdDoctor]) VALUES (17, N'Objawy głębokiej amnezji.', N'Przyczyna amnezji nieznana.', N'FIN', CAST(N'2017-06-27T15:59:53.657' AS DateTime), NULL, CAST(N'2017-06-29T08:00:00.000' AS DateTime), 12, 8, 11)
INSERT [dbo].[Visit] ([Id], [Description], [Diagnosis], [Status], [RegistrationDate], [ResolutionDate], [PlannedDate], [IdRegistrator], [IdPatient], [IdDoctor]) VALUES (18, N'Pacjent utyka na lewą nogę. Rana postrzałowa lewej łydki, amoatorsko opatrzona przed 3-4 dniami. Temperatura w normie, brak zakażenia.', N'Kość nieuszkodzona, kula nie utkwiła w ciele.', N'FIN', CAST(N'2017-06-27T16:00:40.617' AS DateTime), NULL, CAST(N'2017-06-27T08:45:00.000' AS DateTime), 12, 9, 11)
INSERT [dbo].[Visit] ([Id], [Description], [Diagnosis], [Status], [RegistrationDate], [ResolutionDate], [PlannedDate], [IdRegistrator], [IdPatient], [IdDoctor]) VALUES (19, N'Halucynacje, mowa niewyraźna, podwyższona temperatura.', NULL, N'CAN', CAST(N'2017-06-27T16:01:10.383' AS DateTime), CAST(N'2017-06-27T16:01:42.350' AS DateTime), CAST(N'2017-06-30T11:45:00.000' AS DateTime), 12, 11, 9)
INSERT [dbo].[Visit] ([Id], [Description], [Diagnosis], [Status], [RegistrationDate], [ResolutionDate], [PlannedDate], [IdRegistrator], [IdPatient], [IdDoctor]) VALUES (20, N'Pacjent doświadcza silnych halucynacji.', N'Wstrząs mózgu. Zalecana hospitalizacja.', N'FIN', CAST(N'2017-06-27T16:01:56.217' AS DateTime), NULL, CAST(N'2017-07-01T10:00:00.000' AS DateTime), 12, 11, 9)
INSERT [dbo].[Visit] ([Id], [Description], [Diagnosis], [Status], [RegistrationDate], [ResolutionDate], [PlannedDate], [IdRegistrator], [IdPatient], [IdDoctor]) VALUES (21, N'Pacjent cierpi na okazjonalne utraty przytomności i bóle brzucha. Ciśnienie tętniczne niskie.', N'Prawdopodobne uszkodzenie jamy brzusznej i krwotok wewnętrzny.', N'FIN', CAST(N'2017-06-27T16:03:01.327' AS DateTime), NULL, CAST(N'2017-06-30T12:45:00.000' AS DateTime), 12, 12, 10)
INSERT [dbo].[Visit] ([Id], [Description], [Diagnosis], [Status], [RegistrationDate], [ResolutionDate], [PlannedDate], [IdRegistrator], [IdPatient], [IdDoctor]) VALUES (22, N'', NULL, N'SCH', CAST(N'2017-06-27T16:38:25.510' AS DateTime), NULL, CAST(N'2017-07-06T08:00:00.000' AS DateTime), 14, 13, 9)
SET IDENTITY_INSERT [dbo].[Visit] OFF
INSERT [dbo].[LabAssistant] ([Id], [Name], [Surname]) VALUES (15, N'Andrew', N'Johnson')
INSERT [dbo].[LabAssistant] ([Id], [Name], [Surname]) VALUES (16, N'Joe', N'Black')
INSERT [dbo].[TestDictionary] ([Code], [Type], [Name]) VALUES (N'EKG', N'L', N'Elektrokardiogram')
INSERT [dbo].[TestDictionary] ([Code], [Type], [Name]) VALUES (N'H1', N'L', N'Hemoglobina')
INSERT [dbo].[TestDictionary] ([Code], [Type], [Name]) VALUES (N'PRES', N'P', N'Pomiar ciśnienia')
INSERT [dbo].[TestDictionary] ([Code], [Type], [Name]) VALUES (N'RTG', N'L', N'Prześwietlenie rentgenowskie')
INSERT [dbo].[TestDictionary] ([Code], [Type], [Name]) VALUES (N'TK', N'L', N'Tomografia komputerowa')
INSERT [dbo].[TestDictionary] ([Code], [Type], [Name]) VALUES (N'TMP', N'P', N'Pomiar temperatury')
INSERT [dbo].[TestDictionary] ([Code], [Type], [Name]) VALUES (N'USG', N'L', N'Ultrasonogram')
SET IDENTITY_INSERT [dbo].[LaboratoryTest] ON 

INSERT [dbo].[LaboratoryTest] ([Id], [DoctorNotes], [ComissionDate], [Result], [ExecutionDate], [ManagerNotes], [ResolutionDate], [Status], [IdVisit], [IdLabManager], [IdLabAssistant], [Code]) VALUES (26, N'Sprawdzić pod kątem raka mózgu.', CAST(N'2017-06-27T16:18:05.003' AS DateTime), N'Guz w lewym płacie skroniowym, średnica 3 cm.', CAST(N'2017-06-27T16:32:39.623' AS DateTime), N'', CAST(N'2017-06-27T16:37:46.393' AS DateTime), N'APP', 12, 17, 15, N'TK')
INSERT [dbo].[LaboratoryTest] ([Id], [DoctorNotes], [ComissionDate], [Result], [ExecutionDate], [ManagerNotes], [ResolutionDate], [Status], [IdVisit], [IdLabManager], [IdLabAssistant], [Code]) VALUES (27, N'Empty', CAST(N'2017-06-27T16:18:29.140' AS DateTime), N'12 g / dl', CAST(N'2017-06-27T16:34:13.750' AS DateTime), N'', CAST(N'2017-06-27T16:36:11.267' AS DateTime), N'APP', 12, 17, 15, N'H1')
INSERT [dbo].[LaboratoryTest] ([Id], [DoctorNotes], [ComissionDate], [Result], [ExecutionDate], [ManagerNotes], [ResolutionDate], [Status], [IdVisit], [IdLabManager], [IdLabAssistant], [Code]) VALUES (28, N'Empty', CAST(N'2017-06-27T16:19:48.503' AS DateTime), N'Brak odchyleń od normy.', CAST(N'2017-06-27T16:32:52.977' AS DateTime), N'Empty', NULL, N'EXE', 20, 0, 15, N'TK')
INSERT [dbo].[LaboratoryTest] ([Id], [DoctorNotes], [ComissionDate], [Result], [ExecutionDate], [ManagerNotes], [ResolutionDate], [Status], [IdVisit], [IdLabManager], [IdLabAssistant], [Code]) VALUES (29, N'Podejrzenie uszkodzenia jamy brzusznej.', CAST(N'2017-06-27T16:22:38.760' AS DateTime), N'Pacjent nie stawił się na badanie.', CAST(N'2017-06-27T16:34:44.850' AS DateTime), N'Empty', NULL, N'CBA', 21, 0, 16, N'USG')
INSERT [dbo].[LaboratoryTest] ([Id], [DoctorNotes], [ComissionDate], [Result], [ExecutionDate], [ManagerNotes], [ResolutionDate], [Status], [IdVisit], [IdLabManager], [IdLabAssistant], [Code]) VALUES (30, N'Prześwietlić lewą łydkę.', CAST(N'2017-06-27T16:25:10.770' AS DateTime), N'Brak ciał obcych w ciele, kość nieuszkodzona.', CAST(N'2017-06-27T16:35:22.500' AS DateTime), N'Empty', NULL, N'EXE', 18, 0, 16, N'RTG')
INSERT [dbo].[LaboratoryTest] ([Id], [DoctorNotes], [ComissionDate], [Result], [ExecutionDate], [ManagerNotes], [ResolutionDate], [Status], [IdVisit], [IdLabManager], [IdLabAssistant], [Code]) VALUES (31, N'Empty', CAST(N'2017-06-27T16:27:44.923' AS DateTime), N'Brak odchyleń od normy.', CAST(N'2017-06-27T16:33:08.740' AS DateTime), N'Empty', NULL, N'EXE', 17, 0, 15, N'TK')
INSERT [dbo].[LaboratoryTest] ([Id], [DoctorNotes], [ComissionDate], [Result], [ExecutionDate], [ManagerNotes], [ResolutionDate], [Status], [IdVisit], [IdLabManager], [IdLabAssistant], [Code]) VALUES (32, N'Prześwietlenie mózgoczaszki.', CAST(N'2017-06-27T16:27:51.947' AS DateTime), N'Pacjent nie stawił się na badanie.', CAST(N'2017-06-27T16:35:07.197' AS DateTime), N'Empty', NULL, N'CBA', 17, 0, 16, N'RTG')
INSERT [dbo].[LaboratoryTest] ([Id], [DoctorNotes], [ComissionDate], [Result], [ExecutionDate], [ManagerNotes], [ResolutionDate], [Status], [IdVisit], [IdLabManager], [IdLabAssistant], [Code]) VALUES (33, N'Prześwietlić głowę.', CAST(N'2017-06-27T16:39:52.853' AS DateTime), NULL, NULL, N'Empty', NULL, N'SCH', 12, 0, NULL, N'RTG')
SET IDENTITY_INSERT [dbo].[LaboratoryTest] OFF
SET IDENTITY_INSERT [dbo].[Address] ON 

INSERT [dbo].[Address] ([IsValid], [Id], [PatientId], [City], [Street], [HouseNumber], [FlatNumber]) VALUES (1, 6, 6, N'Chicago', N'Crimson', N'12', N'13')
INSERT [dbo].[Address] ([IsValid], [Id], [PatientId], [City], [Street], [HouseNumber], [FlatNumber]) VALUES (0, 7, 7, N'New York', N'4th St,', N'45', N'4')
INSERT [dbo].[Address] ([IsValid], [Id], [PatientId], [City], [Street], [HouseNumber], [FlatNumber]) VALUES (1, 8, 7, N'Katowice', N'3-ciego Maja', N'11b', N'3')
INSERT [dbo].[Address] ([IsValid], [Id], [PatientId], [City], [Street], [HouseNumber], [FlatNumber]) VALUES (1, 9, 8, N'Los Angeles', N'Summer St.', N'107', N'1')
INSERT [dbo].[Address] ([IsValid], [Id], [PatientId], [City], [Street], [HouseNumber], [FlatNumber]) VALUES (1, 10, 9, N'Las Vegas', N'Sunset Bvd.', N'99', N'12')
INSERT [dbo].[Address] ([IsValid], [Id], [PatientId], [City], [Street], [HouseNumber], [FlatNumber]) VALUES (1, 11, 10, N'Los Angeles', N'Sunset Bvd.', N'17', N'1')
INSERT [dbo].[Address] ([IsValid], [Id], [PatientId], [City], [Street], [HouseNumber], [FlatNumber]) VALUES (1, 12, 11, N'Washington DC', N'Pennsylvania Ave.', N'1600', N'1')
INSERT [dbo].[Address] ([IsValid], [Id], [PatientId], [City], [Street], [HouseNumber], [FlatNumber]) VALUES (1, 13, 12, N'Washington DC', N'1st St.', N'66', N'3')
INSERT [dbo].[Address] ([IsValid], [Id], [PatientId], [City], [Street], [HouseNumber], [FlatNumber]) VALUES (1, 14, 13, N'San Diego', N'Fire St.', N'66', N'6')
SET IDENTITY_INSERT [dbo].[Address] OFF
SET IDENTITY_INSERT [dbo].[PhysicalTest] ON 

INSERT [dbo].[PhysicalTest] ([Id], [Result], [IdVisit], [Code]) VALUES (1, N'39.3', 12, N'TMP')
INSERT [dbo].[PhysicalTest] ([Id], [Result], [IdVisit], [Code]) VALUES (2, N'102 / 60', 21, N'PRES')
INSERT [dbo].[PhysicalTest] ([Id], [Result], [IdVisit], [Code]) VALUES (3, N'36.7', 18, N'TMP')
SET IDENTITY_INSERT [dbo].[PhysicalTest] OFF
INSERT [dbo].[LabManager] ([Id], [Name], [Surname]) VALUES (17, N'Leonard', N'Church')
