A script-db-szin2x.sql a komparalashoz módosítva lett; pl. a táblak elofordulási sorrendjén valtoztattam.

# compare szin - szin2

A szin2 adatbazis az alabbiakban tér el (az elso a szin, a második a szin2):

1. databese set-ek

ALTER DATABASE [szin] SET  DISABLE_BROKER 
ALTER DATABASE [szin] SET  ENABLE_BROKER 

ALTER DATABASE [szin] SET READ_COMMITTED_SNAPSHOT OFF 
ALTER DATABASE [szin] SET READ_COMMITTED_SNAPSHOT ON 

2. A modellben levo string property-k

A szin2 adatbázisban rendre nvarchar(max) az összes.

3. A modellben levo Name property-k

A szin2 adatbázisban nincsenek AK-k, tehát konvenció alapján az EF nem generált alternate key-t  a Name mezôkhöz.

4. A ProductSchemaColorAssoc osztály alapján az EF nem generált AK-t

Az asszociativ táblában nem lenne értelme megengedni, hogy legyenek olyan sorok, amelyekben azononos tuple-ök vannak. Tehát a 

	ProductSchemaId, 
	ColorId

attribútumpárnak egyedi kulcsnak kell lennie; lehet, hogy az EF azert hagyta ezt ki, mert látta, hogy van
egyedi kulcsa ennek a tablanak: ProductSchemaColorAssocId IDENTITY(1,1).

_