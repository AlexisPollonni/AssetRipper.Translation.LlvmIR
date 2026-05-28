using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Expected_long_int_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIliEC2ENS0_10unexpectedIiEE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<long, int>::expected(__llvm_libc_20_1_2_::cpp::unexpected<int>)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("unexp.coerce")][NativeType("__llvm_libc_20_1_2_::cpp::unexpected<int>")] int Unexp)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = new Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt
		{
			field_0 = Unexp
		};
		unchecked
		{
			Fputil_internal_FPStorage_v3nexn* field = &((Cpp_expected*)This)->field;
			*(int*)field = Unexpected_int_error.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
			((Cpp_expected*)This)->In_use = 0;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIliEC2El")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<long, int>::expected(long)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("exp")][NativeType("long")] long Exp)
	{
		unchecked
		{
			*(long*)(&((Cpp_expected*)This)->field) = Exp;
			((Cpp_expected*)This)->In_use = 1;
		}
	}
}
