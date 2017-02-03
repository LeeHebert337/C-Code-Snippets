//Create Directory 
//getMyDataPath is a function in a different code snippet
//
string myPath = getMyDataPath();
if (!Directory.Exists(myPath))
{
      Directory.CreateDirectory(myPath);
}
