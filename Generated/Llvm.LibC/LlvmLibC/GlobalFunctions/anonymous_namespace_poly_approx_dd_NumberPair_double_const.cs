using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_114poly_approx_ddERKNS_10NumberPairIdEE")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::poly_approx_dd(__llvm_libc_20_1_2_::NumberPair<double> const&)")]
internal static partial class anonymous_namespace_poly_approx_dd_NumberPair_double_const
{
	public unsafe static Struct_4ydhja Invoke(void* dx)
	{
		NumberPair numberPair = default(NumberPair);
		InlineArray7_NumberPair inlineArray7_NumberPair = default(InlineArray7_NumberPair);
		llvm_lifetime_start_p0.Invoke(112L, &inlineArray7_NumberPair);
		llvm_memcpy_p0_p0_i64.Invoke(&inlineArray7_NumberPair, COEFFS_4zxynj.Pointer, 112L, isVolatile: false);
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = cpp_enable_if_sizeof_NumberPair_double_8ul_NumberPair_double_type_fputil_polyeval_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const_NumberPair_double_const.Invoke(dx, &inlineArray7_NumberPair, Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_NumberPair, sizeof(NumberPair))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_NumberPair, (nint)2 * sizeof(NumberPair))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_NumberPair, (nint)3 * sizeof(NumberPair))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_NumberPair, (nint)4 * sizeof(NumberPair))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_NumberPair, (nint)5 * sizeof(NumberPair))), Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_NumberPair, (nint)6 * sizeof(NumberPair))));
			NumberPair* num = &numberPair;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num = struct_4ydhja2.field_0;
			byte* num2 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja3.field_1;
			llvm_lifetime_end_p0.Invoke(112L, &inlineArray7_NumberPair);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
