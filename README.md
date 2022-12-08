# C# oktatás
### C# oktatáson készült programok, tananyagok

## Első, második óra
- [x] GitHub alapok
- [x] GitHub repo feltöltés
- [x] Merge conflicts gyakorlás
- [x] Markdown gyakorlás
- [ ] LINQ alapok 
   
#### Első óra program, részlet
```
static void Main(string[] args)
        {
            const int max = 1000000000;
            var prev = 0;
            for (int i = 0; i < max; i++)
            {
                var newClass = new SomeClass();
                SomeClass newClass2 = new();
                SomeClass newClass3 = new SomeClass();
                
                if (SomeClass.NumberOfClasses < prev) break;
                prev = SomeClass.NumberOfClasses;
            }
            Console.WriteLine(SomeClass.NumberOfClasses);
        }
```

#### Merge conflicts practice repo: https://github.com/Ant1venom/merge-conflicts-pracice


