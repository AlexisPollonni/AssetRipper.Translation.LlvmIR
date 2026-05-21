using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_long_double_cmp
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIeE3cmpERKS2_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<long double>::cmp(__llvm_libc_20_1_2_::fputil::NormalFloat<long double> const&) const")]
	public unsafe static int Invoke([MangledName("this")] void* This, [MangledName("other")][NativeType("__llvm_libc_20_1_2_::fputil::NormalFloat<long double> const&")] void* Other)
	{
		int num = 0;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = InstructionHelper.Select(Sign_is_neg.Invoke(&((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)This)->Sign), -1, 1);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, &((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)This)->Sign, 1L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)Other)->Sign, 1L, isVolatile: false);
			int result = ((!Llvm_libc_20_1_2_NotEquals_rpctvi.Invoke(anon_izyfb.Val, anon_izyfb2.Val)) ? ((((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)This)->Exponent <= ((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)Other)->Exponent) ? ((((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)This)->Exponent != ((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)Other)->Exponent) ? checked(-num) : ((!NumericHelper.IntCmpUgt(((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)This)->Mantissa, ((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)Other)->Mantissa)) ? ((!NumericHelper.IntCmpEq(((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)This)->Mantissa, ((Llvm_libc_20_1_2_fputil_NormalFloat_wqb3ie*)Other)->Mantissa)) ? checked(-num) : 0) : num)) : num) : num);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
