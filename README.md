Auto_git_builder is a script that builds all branches of the local repository.
	
	How to use Auto_git_builder.

1. Before using the script, you should make sure that the changes on all branches are indexed
and commented out.

2. To use Auto_git_builder, right-click on the icon and select
run with PowerShell.

3. After you should enter the absolute path to your local repository and press Enter.

Then, starting from the branch, the master script will start pushing the updates to the remote repository one by one.
After adding a branch update to a remote repository, the branch begins automatic assembly into the appcenter.
When the build is complete, appcenter sends a build report to the google account.
If the first branch is not yet assembled, and changes are added to the second branch, then the automatic assembly of the 
second branch enters the queue and will wait for the end of the assembly of the first branch.
