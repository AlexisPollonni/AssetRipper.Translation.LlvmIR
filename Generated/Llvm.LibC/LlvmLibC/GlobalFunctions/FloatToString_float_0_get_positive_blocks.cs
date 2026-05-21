using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_float_0_get_positive_blocks
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIfLi0EE19get_positive_blocksEv")]
	[DemangledName("__llvm_libc_20_1_2_::FloatToString<float, 0>::get_positive_blocks()")]
	public unsafe static long Invoke([MangledName("this")] Llvm_libc_20_1_2_FloatToString_vnf553* This)
	{
		int num = 0;
		unchecked
		{
			long result;
			if (This->Exponent < -23)
			{
				result = 0L;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = (int)((This->Exponent >= 0) ? ((ulong)(uint)(This->Exponent + 15L) / 16uL) : 0L);
				result = (uint)Internal_length_for_num.Invoke((int)((long)(uint)num * 16L), 23);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return result;
		}
	}
}
