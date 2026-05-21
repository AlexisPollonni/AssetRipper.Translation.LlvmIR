using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Printf_core_file_write_hook
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, long, void*, int>)(&Invoke));

	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core15file_write_hookENS_3cpp11string_viewEPv")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::file_write_hook(__llvm_libc_20_1_2_::cpp::string_view, void*)")]
	public unsafe static int Invoke([MangledName("new_str.coerce0")] void* New_str, [MangledName("new_str.coerce1")][NativeType("__llvm_libc_20_1_2_::cpp::string_view")] long Fp, [MangledName("fp")][NativeType("void*")] void* Target_file)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		void* f = null;
		long num = 0L;
		unchecked
		{
			*(void**)(&llvm_libc_20_1_2_cpp_string_view) = New_str;
			((long*)(&llvm_libc_20_1_2_cpp_string_view))[1] = Fp;
			Llvm_lifetime_start_p0.Invoke(8L, &f);
			f = Target_file;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = Internal_fwrite_unlocked.Invoke(String_view_data.Invoke(&llvm_libc_20_1_2_cpp_string_view), 1L, String_view_size.Invoke(&llvm_libc_20_1_2_cpp_string_view), f);
			int result = ((num != String_view_size.Invoke(&llvm_libc_20_1_2_cpp_string_view) || Internal_ferror_unlocked.Invoke(f) != 0) ? (-1) : 0);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(8L, &f);
			return result;
		}
	}
}
