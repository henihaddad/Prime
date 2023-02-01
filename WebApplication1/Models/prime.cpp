#include <stdio.h>
#include<math.h>
#include<stdlib.h>
#include<iostream>
#include<string>
#include<fstream>
using namespace std;
bool a[10000000];
//FILE * f;
ofstream myfile;
void primeGenerator(long long n){
    if(n>10000000) return;
    for(int i=0;i<n;i++) a[i]=true;  
    a[0]=0; a[1]=0;  
    for(int i=2;i<sqrt(n);i++){
        for(int j=i*i;j<n;j+=i){
            a[j]=false;
        }
    }
    string s="";
    for(int i=0;i<n;i++) if(a[i]) {
        s+=to_string(i)+" ";
        
        //printf("%d ",i);
    }
    //cout<<s;
    myfile<<s;
    //fprintf(f,"%s ",s);
}
int main(int argc, char **argv) {
    //f=fopen("prime.txt","w+");
    cin.tie(0);
    cout.tie(0);
    ios::sync_with_stdio(false);    
    myfile.open("prime.txt");
    //cout << argv[1]<<endl;
    //fprintf(f,"this is hani haddad's work !\n");
    myfile<<"this is hani haddad's work ! \n";
    size_t idx=0;
    primeGenerator(stol(argv[1],&idx,10));
}

