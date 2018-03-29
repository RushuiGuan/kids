# Required Software
* [Visual Studio Community Edition](https://www.visualstudio.com/downloads/)
* [Visual Studio Code](https://code.visualstudio.com/?wt.mc_id=vscom_downloads)
* [Git for Windows](https://git-scm.com/download/win)
* [GitHub Desktop](https://desktop.github.com/)

# Required Accounts
* https://github.com/
* https://outlook.live.com/owa/

# Invitation
* Go to your email and find a invitation of repository `RushuiGuan/learning` and accept the invitation.

# Setup Folder
1. Create a local folder: c:\Github

# Setup Git Bash
1. Background Read
	* [What is a Bash Shell](https://en.wikipedia.org/wiki/Bash_(Unix_shell))
1. Run Git Bash
1. Observe
	* The colored text is called a shell prompt or prompt
	* The prompt by default should be of the following format: `[user]@[machine] MINGW64 ~`
	* `[user]@[machine]` is green; `[user]` is your current windows login; `[machine]` is your machin host name.
	* `MINGW64` is pink; it has something to do with the version of your bash shell.  Not important.
	* `~` is yellow.  Perhaps the most useful information in the prompt.  It indicates your current working directory as well as your repo branch once you are in a git hub repository. `~` means that you are currently in your default profile folder.
1. Go to your default folder
	* command **(type and press enter)**: `cd ~`
1. Edit your bash profile
	* command: `notepad .bash_profile`
		* Copy and paste the following text to the notepad
		```
		cd /c/github
		alias code="/C/Program\ Files/Microsoft\ VS\ Code/bin/code"
		```	
	* Save and close the notepad
1. Restart Git Bash
1. Verify that Your prompt is: `[UserName]@[MachineName] MINGW64 /c/github`
1. Verify that Visual Studio Code can be launched by typing in the command: `code`
1. Setup the default code editor for bash shell
	* Command: `git config --global core.editor "code --wait"`
1. Learn: the `cd` command and path string in bash shell
	* `cd` means current directory.
	* In bash shell, your path starts with `/` (the first one is called root, not slash), `/c` is your c drive and `/c/github` is the folder github directly under your c drive.
	* `cd /c/github` means changing your current directory to `/c/github`
	* `..` means the parent directory.  If you are in `/c/github`, command `cd ..` will bring you to its parent directory: `/c`
	* `.` means your current directory. 
	* command: `ls`
		* `ls` command will list all files and folders in the current directory.

# Clone the learning Repo
1. Reading: [Github Hello World](https://guides.github.com/activities/hello-world/)
1. Run Git Bash
1. Go to the working folder
	* command: `cd /c/github`
1. Clone the learning repository
	* command: `git clone https://github.com/RushuiGuan/learning`
1. Go to the learning repo folder
	* command: `cd learning`
		* Without specifying the `/` (root), the `cd` command is setting a location relative to your current location.  Since your current location is `/c/github`, the new location should be `/c/github/learning`
	* Verify: Your prompt should reflect the new location
	* Verify: Your prompt should now have something new in light blue `(master)`.  This tells you that you are current 1. in a git repository; 2. in the master branch.
	* Verify:
		* command: `ls`
		* You should see a list a files that has been cloned from the git repository [https://github.com/RushuiGuan/learning](https://github.com/RushuiGuan/learning).

# Create your own working branch
1. Run Git Bash
1. Go to the directory `/c/github/learning`
1. Make sure that you are in the `master` branch
	* Command: `git checkout master`
1. Create your local branch
	* Command: `git branch tuan`
	* By typing this command, a new branch `tuan` will be created from your current branch `master`
1. Switch to the branch that you have just created
	* Command: `git checkout tuan`
1. Push your newly created local branch to the remote repository (cloud).
	* Command: `git push --set-upstream origin tuan`
	* Note: you only need to use flag `--set-upstream` when it is the first push.  The flag associates your local repo tuan with the remote repo of the same name.
1. Verify
	* Browse to [https://github.com/RushuiGuan/learning](https://github.com/RushuiGuan/learning) and you should see the new branch under the branch dropdown.

# Make a change
1. Run Git Bash
1. Go to directory `/c/github/learning`
1. Make sure that your current branch is `tuan`
1. Command: `code readme.md`
	* `code` will open the app "Visual Studio Code"
	* `readme.md` is a parameter to the "Visual Studio Code" program and tells it to open the file.
1. Make some changes to the `readme.md` file.  Any change is fine and save.
1. Go back to the Git Bash.  
1. Assuming your current folder and your current branch didn't change.
1. In order to send your change to the cloud, remember three things
	* Stage - Prepare your changes to be committed.  This step allows you to commit only the changes that you have staged.  
		* Command: `git add .`
	* Commit - Commit your change to the local repo.
		* Command: `git commit . -m "type a message about what you had changed!"`
	* Push - Push your change to the cloud.
		* Command: `git push`
1. Verify
	* Click on this link: [https://github.com/RushuiGuan/learning/tree/tuan](https://github.com/RushuiGuan/learning/tree/tuan)
	* Notice that the link brings you to your branch.
	* Github automatically displays the current readme.md file in the repo directory.  You should be able to see your changes on the screen.
	* Notice that your change is not in any other branches.
1. Celebrate!!!
1. Repeat this section for practics.