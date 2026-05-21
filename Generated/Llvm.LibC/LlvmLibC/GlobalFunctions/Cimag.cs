using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cimag
{
	[MangledName("cimag")]
	[DemangledName("cimag")]
	public unsafe static double Invoke([MangledName("x.coerce0")] double X, [MangledName("x.coerce1")] double X_c)
	{
		Struct_4ydhja struct_4ydhja = default(Struct_4ydhja);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		struct_4ydhja.field_0 = X;
		struct_4ydhja.field_1 = X_c;
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja2 = Cpp_bit_cast_Complex_double_double_complex.Invoke(&struct_4ydhja);
			Llvm_libc_20_1_2_NumberPair* num = &llvm_libc_20_1_2_NumberPair;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja2;
			*(double*)num = struct_4ydhja3.field_0;
			byte* num2 = (byte*)(&llvm_libc_20_1_2_NumberPair) + 8u;
			Struct_4ydhja struct_4ydhja4 = struct_4ydhja2;
			*(double*)num2 = struct_4ydhja4.field_1;
			double hi = llvm_libc_20_1_2_NumberPair.Hi;
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
			return hi;
		}
	}
}
