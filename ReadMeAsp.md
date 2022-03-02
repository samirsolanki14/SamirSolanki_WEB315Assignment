{\rtf1\ansi\ansicpg1252\cocoartf2636
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fswiss\fcharset0 Helvetica;\f1\fmodern\fcharset0 Courier;\f2\fswiss\fcharset0 Helvetica-Bold;
}
{\colortbl;\red255\green255\blue255;\red18\green18\blue18;}
{\*\expandedcolortbl;;\csgenericrgb\c7059\c7059\c7059;}
{\*\listtable{\list\listtemplateid1\listhybrid{\listlevel\levelnfc23\levelnfcn23\leveljc0\leveljcn0\levelfollow0\levelstartat1\levelspace360\levelindent0{\*\levelmarker \{disc\}}{\leveltext\leveltemplateid1\'01\uc0\u8226 ;}{\levelnumbers;}\fi-360\li720\lin720 }{\listname ;}\listid1}}
{\*\listoverridetable{\listoverride\listid1\listoverridecount0\ls1}}
\paperw11900\paperh16840\margl1440\margr1440\vieww15000\viewh12580\viewkind0
\deftab720
\pard\tx566\tx1133\tx1700\tx2267\tx2834\tx3401\tx3968\tx4535\tx5102\tx5669\tx6236\tx6803\pardeftab720\ri-340\partightenfactor0

\f0\fs28 \cf0 \
Author Name: Samir Ashok Solanki\
Student ID: 0785689. \
Title: RazorPageMusic\
\
Step 1\
1)Create a Folder Name \'93RazorPagesMusic\'94 on your system \
2)Open the Visual Studio Code and select the folder \'93RazorPagesMusic\'94\
3)In Visual Studio Code open the terminal and run\
 \'93dotnet new web app\'94 \
4)Run  \'93dotnet run\'94\
\
5)Add this code in terminal \
 \'93dotnet dev-certs https --trust\'94 // this is the https development certificate and select Yes trust the certificate\
\
6)Add the Folder Create \'93Models\'94 and create a class \'93Music.cs\'94 // Add the DataFields in this file\
\
7) dotnet tool uninstall --global dotnet-aspnet-codegenerator. 	//This is the\'a0{\field{\*\fldinst{HYPERLINK "https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet"}}{\fldrslt command-line interface (CLI) tools for EF Core}}\
\
8)dotnet tool install --global dotnet-aspnet-codegenerator  // This is the\'a0{\field{\*\fldinst{HYPERLINK "https://docs.microsoft.com/en-us/aspnet/core/fundamentals/tools/dotnet-aspnet-codegenerator?view=aspnetcore-6.0"}}{\fldrslt aspnet-codegenerator scaffolding tool}}.\
\
9)dotnet tool uninstall --global dotnet-ef // This Uninstall the time tools for EF Core\
\
10)dotnet tool install --global dotnet-ef. // This is used to install the EF Core SQLite provider, which installs the EF Core package as a dependency.\
\
11)dotnet add package Microsoft.EntityFrameworkCore.Design // This is used to add the Packages needed for scaffolding:\
\
12)dotnet add package Microsoft.EntityFrameworkCore.SQLite //This is the package for Microsoft.EntityFrameworkCore.SQLite\
13)dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design /// This is the package for Microsoft.VisualStudio.Web.CodeGeneration.Design\
\
14)dotnet add package Microsoft.EntityFrameworkCore.SqlServer // This is used to add the package\
\
15) 		dotnet-aspnet-codegenerator razorpage -m Music -dc RazorPagesMusicContext -udl -outDir Pages/Musics --referenceScriptLibraries -sqlite. // Open a command shell to the project directory, which contains in the Program.cs\
		\
16)dotnet-aspnet-codegenerator razorpage -h\
\
17)dotnet tool install --global dotnet-ef\
\
18)dotnet ef migrations add InitialCreate\
\
19)dotnet ef database update\
\
\
20)Now Run Dotnet new\
		
\f1 \uc0\u8232 
\f0 \
21) After this in Seed File added the field name for eg:- NameofArtists,MusicReleaseDate,MusicGenre,Review\
\pard\pardeftab720\ri-340\partightenfactor0

\f2\b \cf2 \
\pard\tx566\tx1133\tx1700\tx2267\tx2834\tx3401\tx3968\tx4535\tx5102\tx5669\tx6236\tx6803\pardeftab720\ri-340\partightenfactor0

\f0\b0 \cf2 \
\pard\tx220\tx720\pardeftab720\li720\fi-720\ri-340\partightenfactor0
\ls1\ilvl0\cf2 	\
			\
			
\f1 \uc0\u8232 
\f0 \
\pard\pardeftab720\ri-340\partightenfactor0
\cf0 \
}