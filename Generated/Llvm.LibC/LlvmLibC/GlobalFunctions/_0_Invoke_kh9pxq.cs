using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class _0_Invoke_kh9pxq
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_13__cbrt_impl__EdENK3$_0clEd")]
	[DemangledName("__llvm_libc_20_1_2_::__cbrt_impl__(double)::$_0::operator()(double) const")]
	[CleanName("_0_Invoke")]
	public unsafe static double Invoke([MangledName("this")] void* This, [MangledName("r")][NativeType("double")] double R)
	{
		long num = 0L;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		long x = 0L;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, R);
		unchecked
		{
			long num2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) - 4607182418800017408L;
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			num = num2;
			Llvm_lifetime_start_p0.Invoke(8L, &x);
			x = num + (long)((ulong)(uint)((Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0 << 52);
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, x);
			double result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
