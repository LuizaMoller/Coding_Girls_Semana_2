echo "Push de todos os arquivos para o repo git"
read message
git add .
git commit -m "update"
if [ -n "$(git status - porcelain)" ];
then
 echo "IT IS CLEAN"
else
 git pull origin master	
 git status
 echo "Pushing data to remote server!!!"
 git push origin master
fi