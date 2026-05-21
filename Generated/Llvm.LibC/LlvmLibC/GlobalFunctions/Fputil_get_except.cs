using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_get_except
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10get_exceptEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::get_except()")]
	public unsafe static int Invoke()
	{
		short num = 0;
		short status = 0;
		Llvm_lifetime_start_p0.Invoke(2L, &num);
		unchecked
		{
			num = (short)Internal_get_mxcsr.Invoke();
			Llvm_lifetime_start_p0.Invoke(2L, &status);
			status = (short)((((ushort)num >> 7) ^ -1) & 0x3F);
			int result = Internal_exception_status_to_macro.Invoke(status);
			Llvm_lifetime_end_p0.Invoke(2L, &status);
			Llvm_lifetime_end_p0.Invoke(2L, &num);
			return result;
		}
	}
}
