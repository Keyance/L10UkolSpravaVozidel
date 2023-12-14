using L10UkolSpravaVozidel;

SpravceVozidel sprava = new SpravceVozidel();

sprava.PridejMotorku("Motorka", "2004", "Černá", "Skútr", 2, 120);
sprava.PridejMotorku("Motorka", "1999", "Modrá", "Sporťák", 2, 200);
sprava.PridejAuto("Auto", "2014", "Bílé", 5, "Kombík", 740);
sprava.PridejAuto("Auto", "1995", "Zelené", 3, "Brouček", 354);

sprava.VypisVozidla();