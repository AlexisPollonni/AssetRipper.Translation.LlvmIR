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
	public unsafe static Struct_4ydhja Invoke([MangledName("dx")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* Dx)
	{
		NumberPair numberPair = default(NumberPair);
		InlineArray7_NumberPair inlineArray7_NumberPair = default(InlineArray7_NumberPair);
		Llvm_lifetime_start_p0.Invoke(112L, &inlineArray7_NumberPair);
		Llvm_memcpy_p0_p0_i64.Invoke(&inlineArray7_NumberPair, _49.Pointer, 112L, isVolatile: false);
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_polyeval_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double_NumberPair_double.Invoke(Dx, (NumberPair*)(&inlineArray7_NumberPair), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_NumberPair, sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_NumberPair, (nint)2 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_NumberPair, (nint)3 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_NumberPair, (nint)4 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_NumberPair, (nint)5 * sizeof(NumberPair))), (NumberPair*)Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref inlineArray7_NumberPair, (nint)6 * sizeof(NumberPair))));
			NumberPair* num = &numberPair;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num = struct_4ydhja2.field_0;
			byte* num2 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja3.field_1;
			Llvm_lifetime_end_p0.Invoke(112L, &inlineArray7_NumberPair);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
