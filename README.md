# SearchFight
Cignium Project

Execute the project by running SearchFightApp.exe in Release folder from: SearchFightApp\bin\Release

    C:\SearchFightApp\bin\Release>SearchFightApp.exe java .net
    Searching..
    java: GoogleSearch: 6480000 BingSearch: 25500000
    .net: GoogleSearch: 2210000 BingSearch: 17900000
    GoogleSearch winner : java
    BingSearch winner : java
    Total winner: GoogleSearch


Change Keys in AppConfig from FNT_SearchFightApp folder and also in FNT_SearchFightTests folder:

    <!--GOOGLE-->
    <add key="GoogleUrl" value="https://www.googleapis.com/customsearch/v1?key={0};cx={1};q={2}" />
    <add key="GoogleContext" value="CONTEXT-KEY" />
    <add key="GoogleKey" value="KEY" />
    <!--BING-->
    <add key="BingUrl" value="https://api.cognitive.microsoft.com/bing/v7.0/search?q={0}" />
    <add key="BingKey" value="KEY" />
