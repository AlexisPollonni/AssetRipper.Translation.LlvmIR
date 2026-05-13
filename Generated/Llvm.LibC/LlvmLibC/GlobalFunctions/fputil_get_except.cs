using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10get_exceptEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::get_except()")]
internal static partial class fputil_get_except
{
	public unsafe static int Invoke()
	{
		short num = 0;
		short status = 0;
		llvm_lifetime_start_p0.Invoke(2L, &num);
		unchecked
		{
			num = (short)fputil_internal_get_mxcsr.Invoke();
			llvm_lifetime_start_p0.Invoke(2L, &status);
			status = (short)((((ushort)num >> 7) ^ -1) & 0x3F);
			int result = fputil_internal_exception_status_to_macro_unsigned_short.Invoke(status);
			llvm_lifetime_end_p0.Invoke(2L, &status);
			llvm_lifetime_end_p0.Invoke(2L, &num);
			return result;
		}
	}
}
