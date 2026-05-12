using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZZN19__llvm_libc_20_1_2_13__cbrt_impl__EdENK3$_0clEd")]
[DemangledName("__llvm_libc_20_1_2_::__cbrt_impl__(double)::$_0::operator()(double) const")]
internal static partial class cbrt_impl_double_0_operator_double_const
{
	public unsafe static double Invoke(void* @this, double r)
	{
		long num = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		long x = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, r);
		unchecked
		{
			long num2 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) - 4607182418800017408L;
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			num = num2;
			llvm_lifetime_start_p0.Invoke(8L, &x);
			x = num + (long)((ulong)(uint)((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0 << 52);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm3, x);
			double result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm3);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_lifetime_end_p0.Invoke(8L, &x);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
