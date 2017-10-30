param([string]$serverFQDN='.',[int]$month=3)

 
$curmonth=(get-date).Month
$curyear=(get-date).year

$installedpatches=get-hotfix -ComputerName $serverFQDN | where{($_.InstalledOn.Month -eq $curmonth-$month) -and ($_.InstalledOn.Year -eq $curyear)} |select description,hotfixid,installedon

$installedpatches | ConvertTo-Json

 

