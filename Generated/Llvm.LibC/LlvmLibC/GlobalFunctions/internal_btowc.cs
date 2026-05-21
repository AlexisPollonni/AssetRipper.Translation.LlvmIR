using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_btowc
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal5btowcEi")]
	[DemangledName("__llvm_libc_20_1_2_::internal::btowc(int)")]
	public unsafe static long Invoke([NativeType("int")] int c)
	{
		cpp_optional_g66fk4 cpp_optional_g66fk5 = default(cpp_optional_g66fk4);
		int num = 0;
		if (c > 127 || c < 0)
		{
			optional_unsigned_int_Constructor_d3whqv.Invoke(&cpp_optional_g66fk5);
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = c;
			optional_unsigned_int_Constructor_sqgrhj.Invoke(&cpp_optional_g66fk5, &num);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
		return *unchecked((long*)(&cpp_optional_g66fk5.storage));
	}
}
