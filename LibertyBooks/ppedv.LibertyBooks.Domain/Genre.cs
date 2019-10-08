using System;

namespace ppedv.LibertyBooks.Domain
{
    [Flags]
    public enum Genre 
    { 
        NonFiction = 1,
        Fiction = 2,
        Children = 4,
        Comic = 8,
        Crime = 16,
        Drama = 32,
        Fantasy = 64,
        Romance = 128,
        Travel = 256,
        Health = 512}
}
