using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal5btowcEi")]
[DemangledName("__llvm_libc_20_1_2_::internal::btowc(int)")]
internal static partial class internal_btowc_int
{
	public unsafe static long Invoke(int c)
	{
		cpp_optional_39hkks cpp_optional_39hkks2 = default(cpp_optional_39hkks);
		int num = 0;
		if (c > 127 || c < 0)
		{
			cpp_optional_unsigned_int_optional_cpp_nullopt_t.Invoke(&cpp_optional_39hkks2);
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = c;
			cpp_optional_unsigned_int_optional_unsigned_int.Invoke(&cpp_optional_39hkks2, &num);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
		return *unchecked((long*)(&cpp_optional_39hkks2.storage));
	}
}
