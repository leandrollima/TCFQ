
For Migrations with Developer PowerShell (Visual Studio)
-------------------------------------------------------------
It will be acessed by Menu View -> terminal

For first time maybe you will run these commands:
	-- install tool:
	dotnet tool install --global dotnet-ef

	-- update tool:
	dotnet tool update --global dotnet-ef


For Add Migration:
	dotnet ef migrations add FirstMigration --project "TCFQ.Repository" --startup-project "TCFQ.WF"  --context AppDbContext

For Remove Migration:
	dotnet ef migrations remove --project "TCFQ.Repository" --startup-project "TCFQ.WF"  --context AppDbContext

For Update Database: (automatic on run project)
	dotnet ef database update --project "TCFQ.Repository" --startup-project "TCFQ.WF"  --context AppDbContext

For create database:	
	CREATE DATABASE `tcfq` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;





	Install MySQL Community 8.0.31 Developer Default:
	https://dev.mysql.com/downloads/installer/

	{
      "Id": 22,
      "Answers": [ "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" ],
      "Url":  ""
    }



	
	git update-index --assume-unchanged TCFQ.CO\answers.json
	
	git checkout -- answers.json
