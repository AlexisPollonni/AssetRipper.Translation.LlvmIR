using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_log2_accurate
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_113log2_accurateEiid")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::log2_accurate(int, int, double)")]
	public unsafe static double Invoke([MangledName("e_x")][NativeType("int")] int E_x, [MangledName("index")][NativeType("int")] int Index, [MangledName("m_x")][NativeType("double")] double M_x)
	{
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd2 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd3 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd4 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd6 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd7 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd8 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd9 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd10 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd11 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd12 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd13 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd14 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd15 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd16 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd17 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd18 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd19 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd20 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd21 = default(Fputil_DyadicFloat_kt2kd4);
		Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
		unchecked
		{
			*(sbyte*)(&fputil_DyadicFloat_kt2kd) = -86;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd))[1] = -1431655766;
			sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 8;
			*(long*)ptr2 = -6148914691236517206L;
			((long*)ptr2)[1] = -6148914691236517206L;
			DyadicFloat_128ul_DyadicFloat_float_0.Invoke(&fputil_DyadicFloat_kt2kd, E_x);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd2);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd3, &fputil_DyadicFloat_kt2kd, 24L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd4, (byte*)Anonymous_namespace_LOG2_TABLE.Pointer + (nint)Index * (nint)sizeof(Fputil_DyadicFloat_kt2kd4), 24L, isVolatile: false);
			Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd2, &fputil_DyadicFloat_kt2kd3, &fputil_DyadicFloat_kt2kd4);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd, &fputil_DyadicFloat_kt2kd2, 24L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd2);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd5) = -86;
			sbyte* ptr3 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 1;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd5))[1] = -1431655766;
			sbyte* ptr4 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 8;
			*(long*)ptr4 = -6148914691236517206L;
			((long*)ptr4)[1] = -6148914691236517206L;
			Log_range_reduction.Invoke(&fputil_DyadicFloat_kt2kd5, M_x, Anonymous_namespace_LOG2_TABLE.Pointer, &fputil_DyadicFloat_kt2kd);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd6) = -86;
			sbyte* ptr5 = (sbyte*)(&fputil_DyadicFloat_kt2kd6) + 1;
			*ptr5 = -86;
			ptr5[1] = -86;
			ptr5[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd6))[1] = -1431655766;
			sbyte* ptr6 = (sbyte*)(&fputil_DyadicFloat_kt2kd6) + 8;
			*(long*)ptr6 = -6148914691236517206L;
			((long*)ptr6)[1] = -6148914691236517206L;
			Fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd6, &fputil_DyadicFloat_kt2kd5, (Fputil_DyadicFloat_kt2kd4*)Anonymous_namespace_BIG_COEFFS.Pointer);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd8);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd9, &fputil_DyadicFloat_kt2kd6, 24L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd10, (byte*)Anonymous_namespace_BIG_COEFFS.Pointer + sizeof(Fputil_DyadicFloat_kt2kd4), 24L, isVolatile: false);
			Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd8, &fputil_DyadicFloat_kt2kd9, &fputil_DyadicFloat_kt2kd10);
			Fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd7, &fputil_DyadicFloat_kt2kd5, &fputil_DyadicFloat_kt2kd8);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd6, &fputil_DyadicFloat_kt2kd7, 24L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd8);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd11);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd12);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd13, &fputil_DyadicFloat_kt2kd6, 24L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd14, (byte*)Anonymous_namespace_BIG_COEFFS.Pointer + (nint)2 * sizeof(Fputil_DyadicFloat_kt2kd4), 24L, isVolatile: false);
			Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd12, &fputil_DyadicFloat_kt2kd13, &fputil_DyadicFloat_kt2kd14);
			Fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd11, &fputil_DyadicFloat_kt2kd5, &fputil_DyadicFloat_kt2kd12);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd6, &fputil_DyadicFloat_kt2kd11, 24L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd12);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd11);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd15);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd16);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd17, &fputil_DyadicFloat_kt2kd6, 24L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd18, (byte*)Anonymous_namespace_BIG_COEFFS.Pointer + (nint)3 * sizeof(Fputil_DyadicFloat_kt2kd4), 24L, isVolatile: false);
			Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd16, &fputil_DyadicFloat_kt2kd17, &fputil_DyadicFloat_kt2kd18);
			Fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd15, &fputil_DyadicFloat_kt2kd5, &fputil_DyadicFloat_kt2kd16);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd6, &fputil_DyadicFloat_kt2kd15, 24L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd16);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd15);
			Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd19);
			*(sbyte*)(&fputil_DyadicFloat_kt2kd19) = -86;
			sbyte* ptr7 = (sbyte*)(&fputil_DyadicFloat_kt2kd19) + 1;
			*ptr7 = -86;
			ptr7[1] = -86;
			ptr7[2] = -86;
			((int*)(&fputil_DyadicFloat_kt2kd19))[1] = -1431655766;
			sbyte* ptr8 = (sbyte*)(&fputil_DyadicFloat_kt2kd19) + 8;
			*(long*)ptr8 = -6148914691236517206L;
			((long*)ptr8)[1] = -6148914691236517206L;
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd20, &fputil_DyadicFloat_kt2kd, 24L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd21, &fputil_DyadicFloat_kt2kd6, 24L, isVolatile: false);
			Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd19, &fputil_DyadicFloat_kt2kd20, &fputil_DyadicFloat_kt2kd21);
			double result = DyadicFloat_128ul_Double_double_void.Invoke(&fputil_DyadicFloat_kt2kd19);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd19);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
			Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
			return result;
		}
	}
}
