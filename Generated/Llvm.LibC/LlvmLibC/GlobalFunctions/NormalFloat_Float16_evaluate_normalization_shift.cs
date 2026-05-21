using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_Float16_evaluate_normalization_shift
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIDF16_E28evaluate_normalization_shiftEt")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<_Float16>::evaluate_normalization_shift(unsigned short)")]
	public unsafe static int Invoke(fputil_NormalFloat_epbrnk* @this, [NativeType("unsigned short")] short m)
	{
		int num = 0;
		short num2 = m;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		unchecked
		{
			while ((0x400 & (ushort)num2) == 0 && (uint)num < 10u)
			{
				num2 = (short)((ushort)num2 << 1);
				num++;
			}
			int result = num;
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
