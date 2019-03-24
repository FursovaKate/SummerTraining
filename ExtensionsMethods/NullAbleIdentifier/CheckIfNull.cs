namespace NullAbleIdentifier
{
    public static class CheckIfNull
    {
        public static bool IsNull(this object inputNullable)
        {
            return inputNullable == null;
        }
    }
}