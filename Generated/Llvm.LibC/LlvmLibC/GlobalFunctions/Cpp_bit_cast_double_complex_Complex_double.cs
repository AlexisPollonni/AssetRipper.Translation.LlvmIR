using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_cast_double_complex_Complex_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castICdNS_7ComplexIdEEEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS6_EE5valuesr3cpp21is_trivially_copyableIS6_EE5valuesr3cpp21is_trivially_copyableIS7_EE5valueES6_E4typeERKS7_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (double complex) == sizeof (__llvm_libc_20_1_2_::Complex<double>) && cpp::is_trivially_constructible<double complex>::value && cpp::is_trivially_copyable<double complex>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<double>>::value, double complex>::type __llvm_libc_20_1_2_::cpp::bit_cast<double complex, __llvm_libc_20_1_2_::Complex<double>>(__llvm_libc_20_1_2_::Complex<double> const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (double complex) == sizeof (__llvm_libc_20_1_2_::Complex<double>) && cpp::is_trivially_constructible<double complex>::value && cpp::is_trivially_copyable<double complex>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<double>>::value, double complex>::type")]
	public unsafe static Struct_4ydhja Invoke([MangledName("from")][NativeType("__llvm_libc_20_1_2_::Complex<double> const&")] void* From)
	{
		Struct_4ydhja result = default(Struct_4ydhja);
		unchecked
		{
			double field_ = ((Struct_4ydhja*)From)->field_0;
			double field_2 = ((Struct_4ydhja*)From)->field_1;
			double* ptr = &result.field_1;
			result.field_0 = field_;
			*ptr = field_2;
			return result;
		}
	}
}
