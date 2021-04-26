SC: EF migrate

A c:\repo\a\EF\Associative-Table-ProductSchema-Color-Scaffold\AssoTab.csproj -bol
atmasolt projekt.

Arra vagyok kivancsi, hogy a scaffolded modelt hogy generalja le visszafele,
azaz a modelbol mi lesz az alapmigracio eredmenye.

Miutan atmasoltam a fenti projektet ide, atneveztem a name space-t AssoTabM-re,
azaz M mint migracio, a projektfájl neve is AssoTabM lett.

A Model\ColorContext.cs OnModelCreating rutinjat toroltem, hogy lassam, mit hoz letre a migracio a modellbol.

A OnConfiguring-ban az adatbázis nevét szin-rol szin2-re valtoztattam, 
hogy ossze lehessen majd hasonlitani a két adatbázist.


_