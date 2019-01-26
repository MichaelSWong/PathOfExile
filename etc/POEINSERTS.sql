use PathOfExile

select * from Classes
select * from Ascendancy
select * from Currency

INSERT INTO Classes(classes_name,starting_str,starting_dex,starting_int, classes_image) VALUES ('Duelist',23,23,14,'Duelist_avatar.png')
INSERT INTO Classes(classes_name,starting_str,starting_dex,starting_int, classes_image) VALUES ('Shadow',14,23,23,'Shadow_avatar.png')
INSERT INTO Classes(classes_name,starting_str,starting_dex,starting_int, classes_image) VALUES ('Marauder',32,14,14,'Marauder_avatar.png')
INSERT INTO Classes(classes_name,starting_str,starting_dex,starting_int, classes_image) VALUES ('Witch',14,14,32,'Witch_avatar.png')
INSERT INTO Classes(classes_name,starting_str,starting_dex,starting_int, classes_image) VALUES ('Ranger',14,32,14,'Ranger_avatar.png')
INSERT INTO Classes(classes_name,starting_str,starting_dex,starting_int, classes_image) VALUES ('Templar',23,14,23,'Templar_avatar.png')
INSERT INTO Classes(classes_name,starting_str,starting_dex,starting_int, classes_image) VALUES ('Scion',20,20,20,'Scion_avatar.png')

INSERT INTO Ascendancy (classes_id,ascendancy_name,ascendancy_image)VALUES (1,'Slayer','Slayer_avatar.png');
INSERT INTO Ascendancy (classes_id,ascendancy_name,ascendancy_image)VALUES (1,'Gladiator','Gladiator_avatar.png');
INSERT INTO Ascendancy (classes_id,ascendancy_name,ascendancy_image)VALUES (1,'Champion','Champion_avatar.png');
INSERT INTO Ascendancy (classes_id,ascendancy_name,ascendancy_image)VALUES (2,'Assassin','Assassin_avatar.png');
INSERT INTO Ascendancy (classes_id,ascendancy_name,ascendancy_image)VALUES (2,'Saboteur','Saboteur_avatar.png');
INSERT INTO Ascendancy (classes_id,ascendancy_name,ascendancy_image)VALUES (2,'Trickster','Trickster_avatar.png');
INSERT INTO Ascendancy (classes_id,ascendancy_name,ascendancy_image)VALUES (3,'Juggernaut','Juggernaut_avatar.png');
INSERT INTO Ascendancy (classes_id,ascendancy_name,ascendancy_image)VALUES (3,'Berserker','Berserker_avatar.png');
INSERT INTO Ascendancy (classes_id,ascendancy_name,ascendancy_image)VALUES (3,'Chieftain','Chieftain_avatar.png');
INSERT INTO Ascendancy (classes_id,ascendancy_name,ascendancy_image)VALUES (4,'Necromancer','Necromancer_avatar.png');
INSERT INTO Ascendancy (classes_id,ascendancy_name,ascendancy_image)VALUES (4,'Elementalist','Elementalist_avatar.png');
INSERT INTO Ascendancy (classes_id,ascendancy_name,ascendancy_image)VALUES (4,'Occultist','Occultist_avatar.png');
INSERT INTO Ascendancy (classes_id,ascendancy_name,ascendancy_image)VALUES (5,'Deadeye','Deadeye_avatar.png');
INSERT INTO Ascendancy (classes_id,ascendancy_name,ascendancy_image)VALUES (5,'Raider','Raider_avatar.png');
INSERT INTO Ascendancy (classes_id,ascendancy_name,ascendancy_image)VALUES (5,'Pathfinder','Pathfinder_avatar.png');
INSERT INTO Ascendancy (classes_id,ascendancy_name,ascendancy_image)VALUES (6,'Inquisitor','Inquisitor_avatar.png');
INSERT INTO Ascendancy (classes_id,ascendancy_name,ascendancy_image)VALUES (6,'Hierophant','Hierophant_avatar.png');
INSERT INTO Ascendancy (classes_id,ascendancy_name,ascendancy_image)VALUES (6,'Guardian','Guardian_avatar.png');
INSERT INTO Ascendancy (classes_id,ascendancy_name,ascendancy_image)VALUES (7,'Ascendant','Ascendant_avatar.png');

INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Apprentice_Cartographers_Sextant',10,'ADDS OR REROLLS A MOD FOR A WHITE MAP ON THE ATLAS','Apprentice_Cartographers_Sextant_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Armourers_Scrap',40,'IMPROVES THE QUALITY OF AN ARMOUR','Armourers_Scrap_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Blacksmiths_Whetstone',20,'IMPROVES THE QUALITY OF A WEAPON','Blacksmiths_Whetstone_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Blessed_Orb',20,'RANDOMISES THE NUMERIC VALUES OF THE IMPLICIT MODIFIERS OF AN ITEM','Blessed_Orb_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Cartographers_Chisel',20,'IMPROVES THE QUALITY OF A MAP','Cartographers_Chisel_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Chaos_Orb',10,'REFORGES A RARE ITEM WITH NEW RANDOM MODIFIERS','Chaos_Orb_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Chromatic_Orb',20,'REFORGES THE COLOUR OF SOCKETS ON AN ITEM','Chromatic_Orb_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Divine_Orb',10,'RANDOMISES THE NUMERIC VALUES OF THE RANDOM MODIFIERS ON AN ITEM','Divine_Orb_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Exalted_Orb',10,'ENCHANTS A RARE ITEM WITH A NEW RANDOM MODIFIER','Exalted_Orb_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Gemcutters_Prism',20,'IMPROVES THE QUALITY OF A GEM','Gemcutters_Prism_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Glassblowers_Bauble',20,'IMPROVES THE QUALITY OF A FLASK','Glassblowers_Bauble_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Jewellers_Orb',20,'REFORGES THE NUMBER OF SOCKETS ON AN ITEM','Jewellers_Orb_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Journeyman_Cartographers_Sextant',10,'ADDS OR REROLLS A MOD FOR A YELLOW OR WHITE MAP ON THE ATLAS','Journeyman_Cartographers_Sextant_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Master_Cartographers_Sextant',10,'ADDS OR REROLLS A MOD FOR A WHITE MAP ON THE ATLAS','Master_Cartographers_Sextant_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Mirror_of_Kalandra',10,'CREATES A MIRRORED COPY OF AN ITEM','Mirror_of_Kalandra_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Orb_of_Alchemy',10,'UPGRADES A NORMAL ITEM TO A RARE ITEM','Orb_of_Alchemy_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Orb_of_Alteration',20,'REFORGES A MAGIC ITEM WITH NEW RANDOM MODIFIERS','Orb_of_Alteration_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Orb_of_Annulment',20,'REMOVES A RANDOM MODIFIER FROM AN ITEM','Orb_of_Annulment_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Orb_of_Augmentation',30,'ENCHANTS A MAGIC ITEM WITH A NEW RANDOM MODIFIER','Orb_of_Augmentation_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Orb_of_Fusing',20,'UPGRADES A NORMAL ITEM TO A RANDOM RARITY','Orb_of_Fusing_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Orb_of_Regret',40,'GRANTS A PASSIVE SKILL REFUND POINT','Orb_of_Regret_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Orb_of_Scouring',30,'REMOVES ALL MODIFIERS FROM AN ITEM','Orb_of_Scouring_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Orb_of_Transmutation',40,'UPGRADES A NORMAL ITEM TO A MAGIC ITEM','Orb_of_Transmutation_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Regal_Orb',10,'UPGRADES A MAGIC ITEM TO A RARE ITEM','Regal_Orb_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Scroll_of_Wisdom',40,'IDENTIFIES AN ITEM','Scroll_of_Wisdom_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Silver_Coin',30,'CROSS NAVALIS PALM WITH SILVER TO RECEIVE A PROPHECY','Silver_Coin_icon.png');
INSERT INTO Currency (currency_name,stack_size,description_text,currency_image) VALUES('Vaal_Orb',10,'CORRUPTS AN ITEM, MODIFYING IT UNPREDICTABLY','Vaal_Orb_icon.png');


INSERT INTO forum_post VALUES ('bex', 'Betrayal', 'Get ready for the new league starting Dec. 04', getdate());
INSERT INTO forum_post VALUES ('saiseiryu.', 'Re: Betrayal', 'Awesome! Cant wait', getdate());