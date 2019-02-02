#Zip new published site
Compress-Archive -Path ((Get-Item -Path ".\").FullName + "\..\bin\debug\netcoreapp2.1\") -DestinationPath site.zip

#Remove old deploy package
rm matt-kwiecien-mvc.zip

#Create new deploy package
Compress-Archive -Path site.zip, aws-windows-deployment-manifest.json -DestinationPath matt-kwiecien-mvc.zip

#Remove site zip
rm site.zip