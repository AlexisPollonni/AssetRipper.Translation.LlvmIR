using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_wctob
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal5wctobEj")]
	[DemangledName("__llvm_libc_20_1_2_::internal::wctob(unsigned int)")]
	public unsafe static long Invoke([NativeType("unsigned int")] int c)
	{
		cpp_optional_g66fk4 cpp_optional_g66fk5 = default(cpp_optional_g66fk4);
		int num = 0;
		if ((c & -128) != 0)
		{
			optional_int_Constructor_ucy85v.Invoke(&cpp_optional_g66fk5);
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = c;
			optional_int_Constructor_952vg9.Invoke(&cpp_optional_g66fk5, &num);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
		return *unchecked((long*)(&cpp_optional_g66fk5.storage));
	}
}
