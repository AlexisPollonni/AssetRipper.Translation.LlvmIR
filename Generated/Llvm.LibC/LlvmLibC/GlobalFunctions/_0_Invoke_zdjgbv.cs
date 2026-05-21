using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class _0_Invoke_zdjgbv
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_12__cos_impl__EdENK3$_0clEj")]
	[DemangledName("__llvm_libc_20_1_2_::__cos_impl__(double)::$_0::operator()(unsigned int) const")]
	[CleanName("_0_Invoke")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* Agg_result, [MangledName("this")] void* This, [MangledName("kk")] int Kk)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = (((Kk & 0x40) == 0) ? (Kk & 0x3F) : (64 - (Kk & 0x3F)));
			*(sbyte*)Agg_result = -86;
			sbyte* ptr = (sbyte*)Agg_result + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)Agg_result)[1] = -1431655766;
			sbyte* ptr2 = (sbyte*)Agg_result + 8;
			*(long*)ptr2 = -6148914691236517206L;
			((long*)ptr2)[1] = -6148914691236517206L;
			long num2 = (uint)num;
			Llvm_memcpy_p0_p0_i64.Invoke(Agg_result, (byte*)Llvm_libc_20_1_2_SIN_K_PI_OVER_128_F128_57.Pointer + (nint)num2 * sizeof(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4), 24L, isVolatile: false);
			if ((Kk & 0x80) != 0)
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Sign, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
