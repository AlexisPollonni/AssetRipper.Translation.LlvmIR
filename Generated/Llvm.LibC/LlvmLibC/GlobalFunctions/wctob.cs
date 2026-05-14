using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class wctob
{
	public unsafe static int Invoke(int c)
	{
		cpp_optional_g66fk4 cpp_optional_g66fk5 = default(cpp_optional_g66fk4);
		llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_g66fk5);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&cpp_optional_g66fk5);
			*(int*)ptr = -1431655766;
			ptr[4] = -86;
			sbyte* ptr2 = ptr + 5;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			long storage = internal_wctob_unsigned_int.Invoke(c);
			*(long*)(&cpp_optional_g66fk5.storage) = storage;
			int result = ((!cpp_optional_int_has_value_const.Invoke(&cpp_optional_g66fk5)) ? (-1) : (*(int*)cpp_optional_int_value.Invoke(&cpp_optional_g66fk5)));
			llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_g66fk5);
			return result;
		}
	}
}
