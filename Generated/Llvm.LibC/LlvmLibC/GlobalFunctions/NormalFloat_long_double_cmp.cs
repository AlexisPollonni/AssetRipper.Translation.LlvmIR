using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_long_double_cmp
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIeE3cmpERKS2_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<long double>::cmp(__llvm_libc_20_1_2_::fputil::NormalFloat<long double> const&) const")]
	public unsafe static int Invoke(void* @this, [NativeType("__llvm_libc_20_1_2_::fputil::NormalFloat<long double> const&")] void* other)
	{
		int num = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = InstructionHelper.Select(Sign_is_neg.Invoke(&((fputil_NormalFloat_wqb3ie*)@this)->sign), -1, 1);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &((fputil_NormalFloat_wqb3ie*)@this)->sign, 1L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &((fputil_NormalFloat_wqb3ie*)other)->sign, 1L, isVolatile: false);
			int result = ((!NotEquals_rpctvi.Invoke(anon_izyfb8.val, anon_izyfb9.val)) ? ((((fputil_NormalFloat_wqb3ie*)@this)->exponent <= ((fputil_NormalFloat_wqb3ie*)other)->exponent) ? ((((fputil_NormalFloat_wqb3ie*)@this)->exponent != ((fputil_NormalFloat_wqb3ie*)other)->exponent) ? checked(-num) : ((!NumericHelper.IntCmpUgt(((fputil_NormalFloat_wqb3ie*)@this)->mantissa, ((fputil_NormalFloat_wqb3ie*)other)->mantissa)) ? ((!NumericHelper.IntCmpEq(((fputil_NormalFloat_wqb3ie*)@this)->mantissa, ((fputil_NormalFloat_wqb3ie*)other)->mantissa)) ? checked(-num) : 0) : num)) : num) : num);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
