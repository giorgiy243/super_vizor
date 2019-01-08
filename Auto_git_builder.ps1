$Heager = "   Name of branch         Status            Time of end                                         link   `n"

$hdrs = @{"accept"="application/json"; "X-API-Token"='0c5ca43853174efe21d90fe29f00bef2071e35fb';} 
$GitDerectory = Read-Host -Prompt 'Enter your git directory for auto building all local branches'
$GitDerectoryOFsave = Read-Host -Prompt 'Enter directory for auto building report'

$dirOFsve = $GitDerectoryOFsave +"\report_auto_builging.txt"

 cd $GitDerectory
 $m = "master"
 $url = "https://api.appcenter.ms/v0.1/apps/giorgiy243-gmail.com/Aply/branches/" + $m + "/builds"
 git checkout $m
 git push
 do{
 	Start-Sleep -Seconds 10
 	$request = Invoke-RestMethod  -Uri $url -Headers $hdrs
   } while($request[0].status -notlike "completed")

 $Heager | Out-File -filepath $dirOFsve 
 $saveDATA =$Heager + "      master   " + "          "+$request[0].status+"    " + $request[0].finishTime + "      " + "https://appcenter.ms/users/giorgiy243-gmail.com/apps/Aply/build/branches/" + $m + "/builds/" + $request[0].id +"`n" 
 $saveDATA | Out-File -filepath $dirOFsve 
 
 $GitBranchs = git branch
 
 foreach ($item in $GitBranchs)
 {
 	if ($item -notlike "*master*")
 	{
	$url = "https://api.appcenter.ms/v0.1/apps/giorgiy243-gmail.com/Aply/branches/" + $item.Trim() + "/builds"

 	git checkout $item.Trim()
 	git push
 	
 	do{
 		Start-Sleep -Seconds 3 
 		$request = Invoke-RestMethod  -Uri $url -Headers $hdrs
	  } while($request[0].status -notlike "completed")
	$saveDATA  = $saveDATA + "      "+$item.Trim()+"    " + "         "+$request[0].status+"       " + $request[0].finishTime + "        " + "https://appcenter.ms/users/giorgiy243-gmail.com/apps/Aply/build/branches/" + $item.Trim() + "/builds/" + $request[0].id +"`n"
	$saveDATA | Out-File -filepath $dirOFsve 
	}
 }