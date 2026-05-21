using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_float128_evaluate_normalization_shift
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIgE28evaluate_normalization_shiftEo")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<__float128>::evaluate_normalization_shift(unsigned __int128)")]
	public unsafe static int Invoke(fputil_NormalFloat_wqb3ie* @this, [MangledName("m.coerce0")] long m, [MangledName("m.coerce1")] long shift)
	{
		Int128 @int = default(Int128);
		int num = 0;
		unchecked
		{
			*(long*)(&@int) = m;
			((long*)(&@int))[1] = shift;
			Int128 int2 = @int;
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 0;
			while (NumericHelper.IntCmpEq(NumericHelper.BitwiseAnd(0L, int2), 0L) && (uint)num < 112u)
			{
				int2 = NumericHelper.ShiftLeft(int2, 1L);
				num++;
			}
			int result = num;
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
