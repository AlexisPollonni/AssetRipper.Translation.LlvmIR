using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_poly_approx_f128_i3da78
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_116poly_approx_f128ERKNS_6fputil11DyadicFloatILm128EEE.46")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::poly_approx_f128(__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&) (.46)")]
	[CleanName("Anonymous_namespace_poly_approx_f128")]
	public unsafe static void Invoke([MangledName("agg.result")] Fputil_DyadicFloat_kt2kd4* Agg_result, [MangledName("dx")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] Fputil_DyadicFloat_kt2kd4* Dx)
	{
		InlineArray8_Fputil_DyadicFloat_kt2kd4 inlineArray8_Fputil_DyadicFloat_kt2kd = default(InlineArray8_Fputil_DyadicFloat_kt2kd4);
		Llvm_lifetime_start_p0.Invoke(192L, &inlineArray8_Fputil_DyadicFloat_kt2kd);
		Llvm_memcpy_p0_p0_i64.Invoke(&inlineArray8_Fputil_DyadicFloat_kt2kd, _47.Pointer, 192L, isVolatile: false);
		unchecked
		{
			*(sbyte*)Agg_result = -86;
			sbyte* ptr = (sbyte*)Agg_result + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)Agg_result)[1] = -1431655766;
			sbyte* ptr2 = (sbyte*)Agg_result + 8;
			*(long*)ptr2 = -6148914691236517206L;
			((long*)ptr2)[1] = -6148914691236517206L;
			Fputil_polyeval_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(Agg_result, Dx, (Fputil_DyadicFloat_kt2kd4*)(&inlineArray8_Fputil_DyadicFloat_kt2kd), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray8_Fputil_DyadicFloat_kt2kd, sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray8_Fputil_DyadicFloat_kt2kd, (nint)2 * sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray8_Fputil_DyadicFloat_kt2kd, (nint)3 * sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray8_Fputil_DyadicFloat_kt2kd, (nint)4 * sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray8_Fputil_DyadicFloat_kt2kd, (nint)5 * sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray8_Fputil_DyadicFloat_kt2kd, (nint)6 * sizeof(Fputil_DyadicFloat_kt2kd4))), (Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray8_Fputil_DyadicFloat_kt2kd, (nint)7 * sizeof(Fputil_DyadicFloat_kt2kd4))));
			Llvm_lifetime_end_p0.Invoke(192L, &inlineArray8_Fputil_DyadicFloat_kt2kd);
		}
	}
}
