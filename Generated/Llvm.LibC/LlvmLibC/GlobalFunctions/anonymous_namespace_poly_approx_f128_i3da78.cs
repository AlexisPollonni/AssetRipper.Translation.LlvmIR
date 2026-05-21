using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class anonymous_namespace_poly_approx_f128_i3da78
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_116poly_approx_f128ERKNS_6fputil11DyadicFloatILm128EEE.46")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::poly_approx_f128(__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&) (.46)")]
	[CleanName("anonymous_namespace_poly_approx_f128")]
	public unsafe static void Invoke([MangledName("agg.result")] fputil_DyadicFloat_kt2kd4* agg_result, [NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] fputil_DyadicFloat_kt2kd4* dx)
	{
		InlineArray8_fputil_DyadicFloat_kt2kd4 inlineArray8_fputil_DyadicFloat_kt2kd = default(InlineArray8_fputil_DyadicFloat_kt2kd4);
		llvm_lifetime_start_p0.Invoke(192L, &inlineArray8_fputil_DyadicFloat_kt2kd);
		llvm_memcpy_p0_p0_i64.Invoke(&inlineArray8_fputil_DyadicFloat_kt2kd, _47.Pointer, 192L, isVolatile: false);
		unchecked
		{
			*(sbyte*)agg_result = -86;
			sbyte* ptr = (sbyte*)agg_result + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)agg_result)[1] = -1431655766;
			sbyte* ptr2 = (sbyte*)agg_result + 8;
			*(long*)ptr2 = -6148914691236517206L;
			((long*)ptr2)[1] = -6148914691236517206L;
			fputil_polyeval_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(agg_result, dx, (fputil_DyadicFloat_kt2kd4*)(&inlineArray8_fputil_DyadicFloat_kt2kd), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray8_fputil_DyadicFloat_kt2kd, sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray8_fputil_DyadicFloat_kt2kd, (nint)2 * sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray8_fputil_DyadicFloat_kt2kd, (nint)3 * sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray8_fputil_DyadicFloat_kt2kd, (nint)4 * sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray8_fputil_DyadicFloat_kt2kd, (nint)5 * sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray8_fputil_DyadicFloat_kt2kd, (nint)6 * sizeof(fputil_DyadicFloat_kt2kd4))), (fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray8_fputil_DyadicFloat_kt2kd, (nint)7 * sizeof(fputil_DyadicFloat_kt2kd4))));
			llvm_lifetime_end_p0.Invoke(192L, &inlineArray8_fputil_DyadicFloat_kt2kd);
		}
	}
}
