namespace SCAssigment1Tests
{
    internal static class TestContent
    {
        internal const string FailedTestMessage = "Dictionary content is not as expected.";

        internal static class TestCases
        {
            internal static IEnumerable<object[]> Cases =>
            [
                [EmptyInput.Text1, EmptyInput.Text2, EmptyInput.ExpectedResult],
                [SingleWordInput.Text1, SingleWordInput.Text2, SingleWordInput.ExpectedResult],
                [MultipleWordsInput.Text1, MultipleWordsInput.Text2, MultipleWordsInput.ExpectedResult],
                [ComplexInput.Text1, ComplexInput.Text2, ComplexInput.ExpectedResult]
            ];
        }

        internal static class EmptyInput
        {
            public static string Text1 => "";
            public static string Text2 => "  ";
            public static Dictionary<string, int> ExpectedResult => [];
        }

        internal static class SingleWordInput
        {
            public static string Text1 => "Go";
            public static string Text2 => "";
            public static Dictionary<string, int> ExpectedResult => new() { {"Go", 1 } };
        }

        internal static class MultipleWordsInput
        {
            public static string Text1 => "Go do that thing that you do so well";
            public static string Text2 => "I play football well";
            public static Dictionary<string, int> ExpectedResult => new()
            { 
                { "Go", 1 },
                { "do", 2 },
                { "that", 2 },
                { "thing", 1 },
                { "you", 1 },
                { "so", 1 },
                { "well", 2 },
                { "I", 1 },
                { "play", 1 },
                { "football", 1 } 
            };
        }

        internal static class ComplexInput
        {
            public static string Text1 => "   \t \r   \n Go \t foo    \n \t    bar";
            public static string Text2 => "\rbar\n\t    \n\r\t foo     \n\t     ";
            public static Dictionary<string, int> ExpectedResult => new()
            {
                { "Go", 1 },
                { "foo", 2 },
                { "bar", 2 }
            };
        }
    }
}
