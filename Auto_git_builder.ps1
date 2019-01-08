$GitDerectory = Read-Host -Prompt 'Enter your git directory for auto building all local branches'

cd $GitDerectory
$m = "master"
git checkout $m
git push

$GitBranchs = git branch

foreach ($item in $GitBranchs)
{
	if ($item -notlike "*master*")
	{
	git checkout $item.Trim()
	git push
	}
}

$ub = new-object System.UriBuilder -argumentlist 'http', 'myhost.com', 80
$ub |Out-string