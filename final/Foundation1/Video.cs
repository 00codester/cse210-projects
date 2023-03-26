class Video{

string _title = "";
string _author = "";
int _length = 0;
List<Comment> _comments = new List<Comment>();

public Video (string name, string author, int vidLength){
    _title = name;
    _author = author;
    _length = vidLength;
}

private int NumberOfComments(){
    int numComments = _comments.Count;
    return numComments;
}

public void AddComment(string name, string vidCom){
    Comment comment = new Comment(name, vidCom);
    _comments.Add(comment);
}

public void DisplayVideo(){
    Console.WriteLine();
    Console.WriteLine($"Video: {_title}");
    Console.WriteLine($"Author: {_author}");
    Console.WriteLine($"Video Length: {_length}");
    Console.WriteLine($"Number of Comments: {NumberOfComments()}" );
    foreach(Comment comment in _comments){
        comment.DisplayInfo();
    }
}

}