using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_18tan_evalERKNS_6fputil11DyadicFloatILm128EEE")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::tan_eval(__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&)")]
internal static partial class anonymous_namespace_tan_eval_fputil_DyadicFloat_128ul_const
{
	public unsafe static void Invoke([MangledName("agg.result")] fputil_DyadicFloat_kt2kd4* agg_result, void* u)
	{
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		InlineArray9_fputil_DyadicFloat_kt2kd4 inlineArray9_fputil_DyadicFloat_kt2kd = default(InlineArray9_fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd6 = default(fputil_DyadicFloat_kt2kd4);
		llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
		unchecked
		{
			*(sbyte*)(&fputil_DyadicFloat_kt2kd5) = -86;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd5))[1] = -1431655766;
			sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 8;
			*(long*)ptr2 = -6148914691236517206L;
			((long*)ptr2)[1] = -6148914691236517206L;
			fputil_DyadicFloat_128ul_fputil_quick_mul_128ul_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const.Invoke(&fputil_DyadicFloat_kt2kd5, u, u);
			llvm_lifetime_start_p0.Invoke(216L, &inlineArray9_fputil_DyadicFloat_kt2kd);
			llvm_memcpy_p0_p0_i64.Invoke(&inlineArray9_fputil_DyadicFloat_kt2kd, TAN_COEFFS.Pointer, 216L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			cpp_enable_if_sizeof_fputil_DyadicFloat_128ul_8ul_fputil_DyadicFloat_128ul_type_fputil_polyeval_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const.Invoke(&fputil_DyadicFloat_kt2kd6, &fputil_DyadicFloat_kt2kd5, &inlineArray9_fputil_DyadicFloat_kt2kd, Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_fputil_DyadicFloat_kt2kd, sizeof(fputil_DyadicFloat_kt2kd4))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_fputil_DyadicFloat_kt2kd, (nint)2 * sizeof(fputil_DyadicFloat_kt2kd4))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_fputil_DyadicFloat_kt2kd, (nint)3 * sizeof(fputil_DyadicFloat_kt2kd4))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_fputil_DyadicFloat_kt2kd, (nint)4 * sizeof(fputil_DyadicFloat_kt2kd4))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_fputil_DyadicFloat_kt2kd, (nint)5 * sizeof(fputil_DyadicFloat_kt2kd4))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_fputil_DyadicFloat_kt2kd, (nint)6 * sizeof(fputil_DyadicFloat_kt2kd4))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_fputil_DyadicFloat_kt2kd, (nint)7 * sizeof(fputil_DyadicFloat_kt2kd4))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray9_fputil_DyadicFloat_kt2kd, (nint)8 * sizeof(fputil_DyadicFloat_kt2kd4))));
			fputil_DyadicFloat_128ul_fputil_quick_mul_128ul_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const.Invoke(agg_result, u, &fputil_DyadicFloat_kt2kd6);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			llvm_lifetime_end_p0.Invoke(216L, &inlineArray9_fputil_DyadicFloat_kt2kd);
			llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
		}
	}
}
