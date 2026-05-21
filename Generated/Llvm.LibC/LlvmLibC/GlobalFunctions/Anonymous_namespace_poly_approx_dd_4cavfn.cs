using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_poly_approx_dd_4cavfn
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_114poly_approx_ddERKNS_10NumberPairIdEE.48")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::poly_approx_dd(__llvm_libc_20_1_2_::NumberPair<double> const&) (.48)")]
	[CleanName("Anonymous_namespace_poly_approx_dd")]
	public unsafe static Struct_4ydhja Invoke([MangledName("dx")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] Llvm_libc_20_1_2_NumberPair* Dx)
	{
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		InlineArray7_Llvm_libc_20_1_2_NumberPair inlineArray7_Llvm_libc_20_1_2_NumberPair = default(InlineArray7_Llvm_libc_20_1_2_NumberPair);
		Llvm_lifetime_start_p0.Invoke(112L, &inlineArray7_Llvm_libc_20_1_2_NumberPair);
		Llvm_memcpy_p0_p0_i64.Invoke(&inlineArray7_Llvm_libc_20_1_2_NumberPair, _49.Pointer, 112L, isVolatile: false);
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_polyeval_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double.Invoke(Dx, (Llvm_libc_20_1_2_NumberPair*)(&inlineArray7_Llvm_libc_20_1_2_NumberPair), (Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_Llvm_libc_20_1_2_NumberPair, sizeof(Llvm_libc_20_1_2_NumberPair))), (Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_Llvm_libc_20_1_2_NumberPair, (nint)2 * sizeof(Llvm_libc_20_1_2_NumberPair))), (Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_Llvm_libc_20_1_2_NumberPair, (nint)3 * sizeof(Llvm_libc_20_1_2_NumberPair))), (Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_Llvm_libc_20_1_2_NumberPair, (nint)4 * sizeof(Llvm_libc_20_1_2_NumberPair))), (Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_Llvm_libc_20_1_2_NumberPair, (nint)5 * sizeof(Llvm_libc_20_1_2_NumberPair))), (Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_Llvm_libc_20_1_2_NumberPair, (nint)6 * sizeof(Llvm_libc_20_1_2_NumberPair))));
			Llvm_libc_20_1_2_NumberPair* num = &llvm_libc_20_1_2_NumberPair;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num = struct_4ydhja2.field_0;
			byte* num2 = (byte*)(&llvm_libc_20_1_2_NumberPair) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja3.field_1;
			Llvm_lifetime_end_p0.Invoke(112L, &inlineArray7_Llvm_libc_20_1_2_NumberPair);
			return *(Struct_4ydhja*)(&llvm_libc_20_1_2_NumberPair);
		}
	}
}
