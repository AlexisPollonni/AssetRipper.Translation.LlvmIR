using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_get_round
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9get_roundEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::get_round()")]
	public unsafe static int Invoke()
	{
		short num = 0;
		llvm_lifetime_start_p0.Invoke(2L, &num);
		unchecked
		{
			num = (short)((internal_get_mxcsr.Invoke() >>> 13) & 3);
			int result = (ushort)num switch
			{
				0 => 0, 
				1 => 1024, 
				2 => 2048, 
				3 => 3072, 
				_ => -1, 
			};
			llvm_lifetime_end_p0.Invoke(2L, &num);
			return result;
		}
	}
}
