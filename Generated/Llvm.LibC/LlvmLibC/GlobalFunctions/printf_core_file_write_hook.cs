using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class printf_core_file_write_hook
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, long, void*, int>)(&Invoke));

	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core15file_write_hookENS_3cpp11string_viewEPv")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::file_write_hook(__llvm_libc_20_1_2_::cpp::string_view, void*)")]
	public unsafe static int Invoke([MangledName("new_str.coerce0")] void* new_str, [MangledName("new_str.coerce1")][NativeType("__llvm_libc_20_1_2_::cpp::string_view")] long fp, [MangledName("fp")][NativeType("void*")] void* target_file)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		void* f = null;
		long num = 0L;
		unchecked
		{
			*(void**)(&cpp_string_view2) = new_str;
			((long*)(&cpp_string_view2))[1] = fp;
			llvm_lifetime_start_p0.Invoke(8L, &f);
			f = target_file;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = internal_fwrite_unlocked.Invoke(string_view_data.Invoke(&cpp_string_view2), 1L, string_view_size.Invoke(&cpp_string_view2), f);
			int result = ((num != string_view_size.Invoke(&cpp_string_view2) || internal_ferror_unlocked.Invoke(f) != 0) ? (-1) : 0);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(8L, &f);
			return result;
		}
	}
}
