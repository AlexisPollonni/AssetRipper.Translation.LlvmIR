using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class _0_Invoke_wjghzm
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_12__tan_impl__EdENK3$_0clEj")]
	[DemangledName("__llvm_libc_20_1_2_::__tan_impl__(double)::$_0::operator()(unsigned int) const")]
	[CleanName("_0_Invoke")]
	public unsafe static void Invoke([MangledName("agg.result")] fputil_DyadicFloat_kt2kd4* agg_result, void* @this, int kk)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = (((kk & 0x40) == 0) ? (kk & 0x3F) : (64 - (kk & 0x3F)));
			*(sbyte*)agg_result = -86;
			sbyte* ptr = (sbyte*)agg_result + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)agg_result)[1] = -1431655766;
			sbyte* ptr2 = (sbyte*)agg_result + 8;
			*(long*)ptr2 = -6148914691236517206L;
			((long*)ptr2)[1] = -6148914691236517206L;
			long num2 = (uint)num;
			llvm_memcpy_p0_p0_i64.Invoke(agg_result, (byte*)SIN_K_PI_OVER_128_F128.Pointer + (nint)num2 * sizeof(fputil_DyadicFloat_kt2kd4), 24L, isVolatile: false);
			if ((kk & 0x80) != 0)
			{
				llvm_memcpy_p0_p0_i64.Invoke(&agg_result->sign, Sign_NEG.Pointer, 1L, isVolatile: false);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
