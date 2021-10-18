using StronglyTypedIds;

[assembly: StronglyTypedIdDefaults(
    backingType: StronglyTypedIdBackingType.Int,
    implementations: StronglyTypedIdImplementations.IEquatable | StronglyTypedIdImplementations.IComparable,
    converters: StronglyTypedIdConverter.TypeConverter)]

namespace LiveUnitTestProblemSample
{
    [StronglyTypedId]
    public partial struct HelperClassId
    {
    }

    public static class NotWorkingHelperClass
    {
        public static string DoWork()
        {
            return "hello";
        }
    }
}