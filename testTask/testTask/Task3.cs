namespace testTask
{
    public class Tree
    {
        public string Name { get; set; }
        public IEnumerable<Tree> Children { get; set; }

    }

    internal class Task3 : ITestTask
    {
        public void SolveTask()
        {
            InitTree(out Tree tree);
            PrintTree(tree);
        }

        private void InitTree(out Tree tree)
        {
            tree = new Tree
            {
                Name = "head",
                Children = new List<Tree>()
                {
                    new Tree
                    {
                        Name = "first childe of head",
                        Children = new List<Tree>()
                        {
                            new Tree
                            {
                                Name = "first child of first child of head"
                            },
                            new Tree
                            {
                                Name = "second child of first child of head"
                            },
                            new Tree
                            {
                                Name = "third child of first child of head"
                            },
                            null
                        }
                    },
                    new Tree
                    {
                        Name = "second child of head",
                        Children = new List<Tree>()
                        {
                            new Tree
                            {
                                Name = "first child of second child of head"
                            },
                            new Tree
                            {
                                Name = "second child of second child of head"
                            }
                        }
                    },
                    null,
                    null
                }
            };

        }

        private void PrintTree(Tree tree)
        {
            if (tree == null)
                return;
            Console.WriteLine(tree.Name);

            if (tree.Children == null)
                return;
            foreach (var element in tree.Children)
            {
                if(element != null)
                    PrintTree(element);
            }
        }
    }
}
